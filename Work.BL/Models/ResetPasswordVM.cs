using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Models
{
    public class ResetPasswordVM
    {
        [MinLength(6, ErrorMessage = "Min Length Is 6")]
        [Required(ErrorMessage = "This Field Is Required")]
        public string OldPassword { get; set; }
        
        [MinLength(6, ErrorMessage = "Min Length Is 6")]
        [Required(ErrorMessage = "This Field Is Required")]
        public string NewPassword { get; set; }

        [MinLength(6, ErrorMessage = "Min Length Is 6")]
        [Required(ErrorMessage = "This Field Is Required")]
        [Compare("NewPassword", ErrorMessage = "Password Not Match")]
        public string ConfirmPassword { get; set; }
        public string Id { get; set; }
    }
}
