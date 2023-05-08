using Work.DAL.Extend;
using Work.BL.Interface;
using Microsoft.AspNetCore.Identity;
using Invoices.BL.Models;
using Work.BL.Models;
using System.Linq.Expressions;
using AutoMapper;

namespace Work.BL.Repository
{
    public class UserRep : IUserRep
    {
        #region Fields
        private readonly UserManager<ApplicationUser> userManager;
        #endregion

        #region Ctor
        public UserRep(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        #endregion

        #region Actions

        public IEnumerable<ApplicationUser> Get(Expression<Func<ApplicationUser, bool>> filter = null)
        {
            try
            {

                if (filter == null)
                {
                    var data = userManager.Users;
                    return data;
                }
                else
                {
                    var data = userManager.Users.Where(filter);
                    return data;
                }
            }
            catch
            {
                return Enumerable.Empty<ApplicationUser>();
            }
        }

        public async Task<ApplicationUser> GetById(string id)
        {
            var data = await userManager.FindByIdAsync(id);
            return data;
        }
        
        public async Task<ApplicationUser> GetByName(string Name)
        {
            var data = await userManager.FindByNameAsync(Name);
            return data;
        }

        public async Task<ApplicationUser> Create(RegisterVM obj)
        {
			var user = new ApplicationUser()
			{
				UserName = obj.Email,
				Email = obj.Email,
				IsAgree = obj.IsAgree
			};

			var AddUser = await userManager.CreateAsync(user, obj.Password);
            return user;
				
		}
        public async Task<ApplicationUser> Edit(ApplicationUser obj)
        {
            var data = await userManager.FindByIdAsync(obj.Id);

            data.UserName = obj.Email;
            data.Email = obj.Email;
            data.FirstName = obj.FirstName;
            data.LastName = obj.LastName;
            data.Bio = obj.Bio;
            data.PhoneNumber = obj.PhoneNumber;
            data.Job = obj.Job;

            await userManager.UpdateAsync(data);
            return data;
        }
        public async Task<ApplicationUser> UploadProfilePic(string PicName, string UserId)
        {
            var data = await userManager.FindByIdAsync(UserId);
            data.PicName = PicName;

            await userManager.UpdateAsync(data);
            return data;

        }

        public async Task<ApplicationUser> Delete(ApplicationUser obj)
        {
            var user = await userManager.FindByIdAsync(obj.Id);

            await userManager.DeleteAsync(user);
            return obj;
        }


        #endregion
    }
}
