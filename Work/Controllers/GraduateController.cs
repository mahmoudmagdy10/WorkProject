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
            var attachments = projectAttachments.Get();
            ViewBag.attachments = attachments;
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


        public async Task<IActionResult> DownloadFile(string fileName, string type)
        {
            if (string.IsNullOrEmpty(fileName) || fileName == null)
            {
                return Content("File Name is Empty...");
            }

            string filePath;

            if (type == "Paper")
            {
                // get the filePath
                filePath = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/Files/PaperAttachments", fileName);
            }
            else
            {
                filePath = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/Files/ProjectAttachments", fileName);

            }

            // create a memorystream
            var memoryStream = new MemoryStream();

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memoryStream);
            }
            // set the position to return the file from
            memoryStream.Position = 0;

            return File(memoryStream, Path.GetFileName(filePath));

        }
        #endregion

    }
}
