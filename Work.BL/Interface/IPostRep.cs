using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.BL.Interface
{
    public interface IPostRep
    {
        IEnumerable<PostVM> Get(Expression<Func<Post, bool>> filter = null);
        PostVM GetById(int id);
        PostVM Create(PostVM obj);
        void Edit(PostVM obj);
        void Delete(PostVM obj);
    }
}
