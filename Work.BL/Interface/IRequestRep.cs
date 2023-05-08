using System.Linq.Expressions;
using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.BL.Interface
{
    public interface IRequestRep
    {
        IEnumerable<RequestVM> Get(Expression<Func<Request, bool>> filter = null);
        RequestVM GetById(int id);
        RequestVM Create(RequestVM obj);
        void Edit(RequestVM obj);
        void Delete(RequestVM obj);
    }
}
