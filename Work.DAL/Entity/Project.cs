using System.ComponentModel.DataAnnotations;
using Work.DAL.Extend;

namespace Work.DAL.Entity
{
    public class Project
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required, StringLength(50)]
        public string Description { get; set; }
        public int Budget { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<ProjectAttachments> ProjectAttachments { get; set; }

    }
}
