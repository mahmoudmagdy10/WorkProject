
using Microsoft.AspNetCore.SignalR;
using System.Net.Http;
using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Database;
using Work.DAL.Entity;

namespace Work.BL.Helper.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly WorkContext db;
        private readonly IRequestRep requestRep;
        private readonly IProjectRep projectRep;

        public NotificationHub(WorkContext db,IRequestRep requestRep, IProjectRep projectRep)
        {
            this.db = db;
            this.requestRep = requestRep;
            this.projectRep = projectRep;
        }
        public override Task OnConnectedAsync()
        {

            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);

            return base.OnConnectedAsync();
        }

        public Task SendNotification(string sender, string receiver,string? PId)
        {
            if (PId != null)
            {
                var ProjectId = int.Parse(PId);

                var IsFound = db.Request.Where(a => a.ProjectId == ProjectId).Where(a => a.SenderEmail == sender).FirstOrDefault();

                if (IsFound == null)
                {

                    var NotificationData = new RequestVM()
                    {
                        SenderEmail = sender,
                        ReceiverEmail = receiver,
                        ProjectId = ProjectId
                    };
                    requestRep.Create(NotificationData);
                }
            }
            else 
            {
                var NotificationData = new RequestVM()
                {
                    SenderEmail = sender,
                    ReceiverEmail = receiver,
                    ProjectId = 0
                };
                requestRep.Create(NotificationData);
            }

            return Clients.Group(receiver).SendAsync("ReceiveRequest", sender);
        }
    }
}
