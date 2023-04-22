using Work.DAL.Extend;
using Work.BL.Models;
using System.Linq.Expressions;

namespace Work.BL.Interface
{
    public interface IUserRep
    {
        IEnumerable<ApplicationUser> Get();
        Task<ApplicationUser> GetById(string id);
        Task<ApplicationUser> GetByName(string Name);
        Task<ApplicationUser> Create(RegisterVM obj);
        Task<ApplicationUser> Edit(ApplicationUser obj);
        Task<ApplicationUser> Delete(ApplicationUser obj);
    }
}
