using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Extend;

namespace Work.DAL.Entity
{
    public class ProjectAttachments
    {
        public int Id { get; set; }
        public string PaperName { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
