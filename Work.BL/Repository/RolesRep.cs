using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Extend;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Repository
{
    public class RolesRep : IRolesRep
    {
        #region Fields
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        #endregion

        #region Ctor
        public RolesRep(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        #endregion

        #region Actions

        public async Task AddRoleToUser(UserInRoleVM model)
        {
            var userModel = await userManager.FindByIdAsync(model.UserId);
            await userManager.AddToRoleAsync(userModel, model.RoleName);
        }

        public async Task<IdentityRole> GetById(string Id)
        {
            try
            {
                var role = await roleManager.FindByIdAsync(Id);
                return role;
            }
            catch (Exception)
            {
                return new IdentityRole()
                {
                    Name = null,
                    NormalizedName = null
                };
            }
        }
        #endregion

    }
}
