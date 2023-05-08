using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Entity;
using Work.DAL.Extend;

namespace Work.BL.Models
{
    public class ProjectVM
    {
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Title { get; set; }

        [Required, StringLength(50)]
        public string Description { get; set; }

        public string PaperName { get; set; }
        public string ProjectName { get; set; }
        public int Budget { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ProjectAttachments Attachments { get; set; }

        public IFormFile Paper { get; set; }
        public IFormFile Project { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
