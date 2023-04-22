using System.Linq.Expressions;
using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.BL.Interface
{
    public interface IReplyRep
    {
        IEnumerable<ReplyVM> Get(Expression<Func<Reply, bool>> filter = null);
        ReplyVM GetById(int id);
        void Create(ReplyVM obj);
        void Edit(ReplyVM obj);
        void Delete(ReplyVM obj);
    }
}
