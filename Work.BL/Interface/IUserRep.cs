using Work.DAL.Extend;
using Invoices.BL.Models;
using Work.BL.Models;

namespace Work.BL.Interface
{
    public interface IUserRep
    {
        IEnumerable<ApplicationUser> Get();
        Task<ApplicationUser> GetById(string id);
        Task<ApplicationUser> Create(RegisterVM obj);
        Task<ApplicationUser> Edit(ApplicationUser obj);
        Task<ApplicationUser> Delete(ApplicationUser obj);
    }
}
