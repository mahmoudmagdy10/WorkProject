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
    public interface IProjectAttachmentsRep
    {
        IEnumerable<ProjectAttachmentsVM> Get(Expression<Func<ProjectAttachments, bool>> filter = null);
        ProjectAttachmentsVM GetById(int id);
        void Create(ProjectVM obj, int ProjectId);
        void Delete(ProjectAttachmentsVM obj);
    }
}
