using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Extend;

namespace Work.DAL.Entity
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int PId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
