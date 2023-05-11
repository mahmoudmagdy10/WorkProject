using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Helper;
using Work.BL.Interface;
using Work.BL.Models;

namespace Work.Controllers
{
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
        [Authorize(Roles = "Graduate,Student")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize(Roles = "Graduate")]
        public IActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Graduate")]
        public IActionResult CreateProject(ProjectVM model)
        {
            try
            {
                var ProjectAttachmentName = UploadingService.UploadFile("/wwwroot/Files/ProjectAttachments", model.Project);
                var PaperAttachmentName = UploadingService.UploadFile("/wwwroot/Files/PaperAttachments", model.Paper);

                model.ProjectName = ProjectAttachmentName;
                model.PaperName = PaperAttachmentName;

                project.Create(model);

                return View("Index");
            }
            catch (Exception)
            {
                TempData["CreatePost"] = "Faild to Create";
                return View();

            }
        }

        [Authorize(Roles = "Graduate,Investor")]
        public async Task<IActionResult> DownloadFile(string fileName, string type)
        {
            if (string.IsNullOrEmpty(fileName) || fileName == null)
            {
                return Content("File Name is Empty...");
            }

            
            var ProjectPath = Directory.GetCurrentDirectory() + "/wwwroot/Files/ProjectAttachments";
            var PaperPath = Directory.GetCurrentDirectory() + "/wwwroot/Files/PaperAttachments";
            var filePath = (type == "Paper") ? PaperPath : ProjectPath;
            var finalPath = Path.Combine(filePath, fileName);

            // create a memorystream
            var memoryStream = new MemoryStream();

            using (var stream = new FileStream(finalPath, FileMode.Open))
            {
                await stream.CopyToAsync(memoryStream);
            }
            // set the position to return the file from
            memoryStream.Position = 0;

            string mimeType = "application/pdf";
            return File(memoryStream, mimeType, Path.GetFileName(finalPath));

        }
        #endregion

    }
}
