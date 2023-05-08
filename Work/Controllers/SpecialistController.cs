using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Work.BL.Interface;
using Work.BL.Models;

namespace Work.Controllers
{
    [Authorize(Roles = "Student,Specialist")]
    public class SpecialistController : Controller
    {
        #region Fields
        private readonly IReplyRep reply;
        private readonly IPostRep post;

        #endregion

        #region Ctor

        public SpecialistController(IReplyRep reply, IPostRep post)
        {
            this.reply = reply;
            this.post = post;
        }

        #endregion

        #region Reply Actions

        [HttpGet]
        public IActionResult Index()
        {
            var data = post.Get().OrderByDescending(a => a.CreatedAt);
            ViewBag.Posts = data;
            return View();
        }

        [HttpGet]
        public IActionResult ShowPosts()
        {
            var data = post.Get().OrderByDescending(a => a.CreatedAt);
            ViewBag.Posts = data;
            return View();
        }

        [HttpPost]
        public IActionResult AddReply(PostVM model)
        {
            try
            {
                var ReplyModel = new ReplyVM()
                {
                    Content = model.Content,
                    UserId = model.UserId,
                    PId = model.PId,
                    UserEmail = model.UserEmail,
                };
                reply.Create(ReplyModel);
                return RedirectToAction("ShowPost", new RouteValueDictionary(new { controller = "Student", action = "ShowPost", UserId = model.UserId, PostId = model.PId }));

            }
            catch (Exception)
            {
                TempData["CreatePost"] = "Faild to Create";
                return RedirectToAction("ShowPost", new RouteValueDictionary(new { controller = "Student", action = "ShowPost", UserId = model.UserId, PostId = model.PId }));

            }
        }

        //[HttpPost]
        //public IActionResult EditPost(PostVM model)
        //{
        //    try
        //    {
        //        post.Edit(model);
        //        return RedirectToAction("CreatePost");

        //    }
        //    catch (Exception)
        //    {
        //        TempData["EditPost"] = "Faild to Edit";
        //        return RedirectToAction("CreatePost");

        //    }
        //}

        //public IActionResult DeletePost(PostVM model)
        //{
        //    try
        //    {
        //        post.Delete(model);
        //        return RedirectToAction("CreatePost");

        //    }
        //    catch (Exception)
        //    {
        //        TempData["DeletePost"] = "Faild to Delete";
        //        return RedirectToAction("CreatePost");

        //    }
        //}
        #endregion
    }
}
