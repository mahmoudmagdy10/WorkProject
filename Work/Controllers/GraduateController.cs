using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.Controllers
{
    [Authorize(Roles= "Graduate")]
    public class GraduateController : Controller
    {
        #region Fields
        private readonly IProjectRep project;
        private readonly IProjectAttachmentsRep projectAttachments;
        #endregion

        #region Ctor
        public GraduateController(IProjectRep project, IProjectAttachmentsRep projectAttachments)
        {
            this.project = project;
            this.projectAttachments = projectAttachments;
        }

        #endregion

        #region Actions
        
        [HttpGet]
        public IActionResult Index()
        {
            var data = project.Get();
            return View(data);
        }
        
        [HttpGet]
        public IActionResult CreateProject(string UserId)
        {
            TempData["UserId"] = UserId;
            return View();
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectVM model)
        {
            try
            {
                var CreatedProject = project.Create(model);
                projectAttachments.Create(model, CreatedProject.Id);

                return RedirectToAction("CreateProject", new RouteValueDictionary(new { controller = "Graduate", action = "CreateProject", UserId = model.UserId }));

            }
            catch (Exception)
            {
                TempData["CreatePost"] = "Faild to Create";
                return RedirectToAction("CreateProject", new RouteValueDictionary(new { controller = "Graduate", action = "CreateProject", UserId = model.UserId }));

            }
        }
        #endregion

    }
}
