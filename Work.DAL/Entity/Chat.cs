using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.DAL.Entity
{
    public class Chat
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string RecieverName { get; set; }
        public string Message { get; set; }
        public string GroupName { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
