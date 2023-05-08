using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.DAL.Extend
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAgree { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? Bio { get; set; }
        
        [StringLength(50), AllowNull]
        public string? FirstName { get; set; }
        
        [StringLength(50), AllowNull]
        public string? LastName { get; set; } 

        [AllowNull] 
        public string? Job { get; set; }

        [AllowNull] 
        public string? PicName { get; set; }

        [AllowNull]
        public int? Rate { get; set; }

    }
}
