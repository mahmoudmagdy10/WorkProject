using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Interface;
using Work.BL.Models;

namespace Work.Controllers
{
    public class StudentController : Controller
    {
        #region Fields

        private readonly IPostRep post;

        #endregion

        #region Ctor

        public StudentController(IPostRep post)
        {
            this.post = post;
        }

        #endregion

        #region Post Actions

        [HttpGet]
        [Authorize(Roles = "Student")]
        public IActionResult CreatePost(string UserId)
        {
            //var model = post.Get();

            TempData["UserId"] = UserId;
            return View();
        }
        
        [Authorize(Roles = "Student")]
        [HttpPost]
        public IActionResult CreatePost(PostVM model)
        {
            try
            {
                post.Create(model);
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));
                //return Json(PostData);

            }
            catch (Exception)
            {
                TempData["CreatePost"] = "Faild to Create";
                //return Json("Faild to Create");
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));


            }
        }

        [HttpGet]
        [Authorize(Roles = ("Student,Specialist"))]
        public IActionResult ShowPost(int PostId, string UserId)
        {
            var model = post.GetById(PostId);
            TempData["UserId"] = UserId;
            ViewBag.PostId = PostId;
            return View(model);
        }

        [Authorize(Roles = "Student")]
        [HttpPost]
        public IActionResult EditPost(PostVM model)
        {
            try
            {
                post.Edit(model);
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));

            }
            catch (Exception)
            {
                TempData["EditPost"] = "Faild to Edit";
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));

            }
        }

        [Authorize(Roles = "Student")]
        public IActionResult DeletePost(PostVM model)
        {
            try
            {
                post.Delete(model);
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));

            }
            catch (Exception)
            {
                TempData["DeletePost"] = "Faild to Delete";
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Specialist", action = "Index", UserId = model.UserId }));

            }
        }
        #endregion
    }
}
