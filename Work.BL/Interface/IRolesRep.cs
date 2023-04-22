using Work.BL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Extend;

namespace Work.BL.Interface
{
    public interface IRolesRep
    {
        Task AddRoleToUser(UserInRoleVM model);
        Task<IdentityRole> GetById(string Id);
    }
}
