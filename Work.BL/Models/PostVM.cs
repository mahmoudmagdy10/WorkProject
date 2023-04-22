using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Models
{
    public class PostVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title Is Required"), MaxLength(50)]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Title Is Required")]
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public int PId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
