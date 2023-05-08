using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Work.BL.Helper;
using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Database;
using Work.DAL.Entity;

namespace Work.BL.Repository
{
    public class ProjectRep : IProjectRep
    {
        #region Fields
        private readonly WorkContext db;
        private readonly IMapper mapper;
        #endregion

        #region Ctor
        public ProjectRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        #endregion

        #region Methods

        public IEnumerable<ProjectVM> Get(Expression<Func<Project, bool>> filter = null)
        {
            try
            {
                if (filter == null)
                {
                    var data = db.Project.Include(p => p.ProjectAttachments).ToList();
                    var projects = mapper.Map<IEnumerable<ProjectVM>>(data);
                    return projects;
                }
                else
                {
                    var data = db.Project.Where(filter);
                    var Projects = mapper.Map<IEnumerable<ProjectVM>>(data);
                    return Projects;
                }
            }
            catch
            {
                return Enumerable.Empty<ProjectVM>();
            }
        }

        public ProjectVM Create(ProjectVM obj)
        {
            try
            {
                var data = mapper.Map<Project>(obj);
                db.Project.Add(data);
                db.SaveChanges();

                var AddedProject = db.Project.OrderBy(a => a.Id).Last();

                return mapper.Map<ProjectVM>(AddedProject);
            }
            catch
            {
                return new ProjectVM();
            }
        }
        
        public ProjectVM Edit(ProjectVM obj)
        {
            var data = mapper.Map<Project>(obj);
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();

            var backedData = db.Project.Where(a => a.Id == obj.Id).FirstOrDefault();
            var backedDataVM = mapper.Map<ProjectVM>(obj);
            return backedDataVM;
        }

        public void Delete(ProjectVM obj)
        {
            var data = mapper.Map<Project>(obj);
            db.Project.Remove(data);
            db.SaveChanges();
        }

        public ProjectVM GetById(int id)
        {
            var data = db.Project.Where(a => a.Id == id).FirstOrDefault();
            var model = mapper.Map<ProjectVM>(data);
            return model;
        }
        #endregion

        #region Refactory Methods
        private IQueryable<Project> GetProjects()
        {
            return db.Project.Include(p => p.ProjectAttachments).Include(u => u.User).Select(a=>a);
        }

        #endregion

    }
}
