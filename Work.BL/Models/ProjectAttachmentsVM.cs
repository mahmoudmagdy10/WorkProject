using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Entity;
using Work.DAL.Extend;

namespace Work.BL.Models
{
    public class ProjectAttachmentsVM
    {
        public int Id { get; set; }
        public string PaperName { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        //public IFormFile Paper { get; set; }
        //public IFormFile Project { get; set; }

    }
}
