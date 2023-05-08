using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Models
{
    public class RequestVM
    {
        public int Id { get; set; }
        
        [AllowNull]
        public bool? Agree { get; set; }

        public int ProjectId { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
