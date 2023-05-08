using Work.BL.Interface;
using Work.BL.Models;
using Microsoft.AspNetCore.SignalR;
using System.Net.Http;

namespace Work.BL.Helper.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRep chat;

        public ChatHub(IChatRep chat)
        {
            this.chat = chat;
        }


        public override Task OnConnectedAsync()
        {

            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);

            return base.OnConnectedAsync();
        }

        public Task JoinGroup(string group)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        public Task SendToGroup(string group, string message, string sender, string receiver, string SendPhoto)
        {
            var ChatData = new ChatVM()
            {
                SenderName = sender,
                RecieverName = receiver,
                Message = message,
                GroupName = group
            };

            chat.Create(ChatData);
            return Clients.Group(group).SendAsync("ReceiveMessage", sender, message, SendPhoto);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public Task SendMessageToGroup(string sender, string receiver, string message)
        //{
        //    var ChatData = new ChatVM()
        //    {
        //        SenderName= sender,
        //        RecieverName = receiver,
        //        Message = message,
        //    };

        //    chat.Create(ChatData);
        //    return Clients.Group(receiver).SendAsync("ReceiveMessage", sender, message);
        //}
        
        //public Task SendRequestChat(string sender, string receiver)
        //{

        //    return Clients.Group(receiver).SendAsync("ReceiveRequest", sender);
        //}

    }
}
