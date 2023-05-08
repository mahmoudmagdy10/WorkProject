using Work.DAL.Extend;
using Work.BL.Models;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity;

namespace Work.BL.Interface
{
    public interface IUserRep
    {
        IEnumerable<ApplicationUser> Get(Expression<Func<ApplicationUser, bool>> filter = null);
        Task<ApplicationUser> GetById(string id);
        Task<ApplicationUser> GetByName(string Name);
        Task<ApplicationUser> Create(RegisterVM obj);
        Task<ApplicationUser> Edit(ApplicationUser obj);
        Task<ApplicationUser> UploadProfilePic(string PicName, string UserId);
        Task<ApplicationUser> Delete(ApplicationUser obj);
    }
}
