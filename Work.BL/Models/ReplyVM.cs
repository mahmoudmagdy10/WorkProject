using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Models
{
    public class ReplyVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Content Is Required")]
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public int PId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
