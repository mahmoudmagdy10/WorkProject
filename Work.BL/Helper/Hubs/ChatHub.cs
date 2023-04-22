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

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public Task SendMessageToGroup(string sender, string receiver, string message)
        {
            var ChatData = new ChatVM()
            {
                SenderName= sender,
                RecieverName = receiver,
                Message = message,
                RecieverId = receiver,
                SenderId = sender
            };

            chat.Create(ChatData);

            return Clients.Group(receiver).SendAsync("ReceiveMessage", sender, message);
        }
    }
}
