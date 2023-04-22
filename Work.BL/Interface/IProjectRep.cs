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
    public interface IProjectRep
    {
        IEnumerable<ProjectVM> Get(Expression<Func<Project, bool>> filter = null);
        ProjectVM GetById(int id);
        ProjectVM Create(ProjectVM obj);
        ProjectVM Edit(ProjectVM obj);
        void Delete(ProjectVM obj);
    }
}
