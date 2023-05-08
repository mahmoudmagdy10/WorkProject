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
    public interface IRateRep
    {
        IEnumerable<RateVM> Get(Expression<Func<Rate, bool>> filter = null);
        void Create(RateVM obj);
        void Edit(RateVM obj);
    }
}
