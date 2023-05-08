using AutoMapper;
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
    public class ProjectAttachmentsRep : IProjectAttachmentsRep
    {
        #region Fields
        private readonly WorkContext db;
        private readonly IMapper mapper;
        #endregion

        #region Ctor
        public ProjectAttachmentsRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void Create(ProjectVM obj, int ProjectId)
        {
            var ProjectAttachmentName = UploadingService.UploadFile("/wwwroot/Files/ProjectAttachments", obj.Project);
            var PaperAttachmentName = UploadingService.UploadFile("/wwwroot/Files/PaperAttachments", obj.Paper);

            ProjectAttachmentsVM AttachmentObj = new ProjectAttachmentsVM()
            {
                ProjectName = ProjectAttachmentName,
                PaperName = PaperAttachmentName,
                ProjectId = ProjectId,
            };

            var data = mapper.Map<ProjectAttachments>(AttachmentObj);
            db.ProjectAttachments.Add(data);
            db.SaveChanges();
                
        }

        public void Delete(ProjectAttachmentsVM obj)
        {
            var data = mapper.Map<ProjectAttachments>(obj);

            UploadingService.RemoveFile("/wwwroot/Files/ProjectAttachments", obj.ProjectName);
            UploadingService.RemoveFile("/wwwroot/Files/PaperAttachments", obj.PaperName);

            db.ProjectAttachments.Remove(data);
            db.SaveChanges();
        }

        public IEnumerable<ProjectAttachmentsVM>  Get(Expression<Func<ProjectAttachments, bool>> filter = null)
        {
            try
            {
                if (filter == null)
                {
                    var data = db.ProjectAttachments.Select(a => a);
                    var projects = mapper.Map<IEnumerable<ProjectAttachmentsVM>>(data);
                    return projects;
                }
                else
                {
                    var data = db.ProjectAttachments.Where(filter);
                    var Projects = mapper.Map<IEnumerable<ProjectAttachmentsVM>>(data);
                    return Projects;
                }
            }
            catch
            {
                return Enumerable.Empty<ProjectAttachmentsVM>();
            }
        }

        public ProjectAttachmentsVM GetById(int id)
        {
            var data = db.Project.Where(a => a.Id == id).FirstOrDefault();
            var model = mapper.Map<ProjectAttachmentsVM>(data);
            return model;
        }
        #endregion

        #region Methods

        #endregion

    }
}
