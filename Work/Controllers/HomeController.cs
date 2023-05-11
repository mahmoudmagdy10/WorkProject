using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Work.BL.Helper;
using Work.BL.Interface;
using Work.BL.Models;
using Work.BL.Repository;
using Work.DAL.Entity;
using Work.DAL.Extend;
using Work.Models;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserRep userRep;
        private readonly IRateRep rateRep;

        public HomeController(UserManager<ApplicationUser> userManager, IUserRep userRep, IRateRep rateRep)
        {
            this.userManager = userManager;
            this.userRep = userRep;
            this.rateRep = rateRep;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterAs()
        {
            return View();
    
        }

        [Authorize]
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult HowItWork()
        {
            return View();
        }


        [HttpGet]
        public IActionResult VisitProfile(string SpecialistId)
        {
            TempData["SpecialistId"] = SpecialistId;
            return View();
        }
        

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Profile(ProfileVM model)
         {
            var UserId = userManager.GetUserId(User);
            try
            {
                var ProfilePicName = UploadingService.UploadFile("/wwwroot/Files/ProfilesPictures", model.Pic);

                await userRep.UploadProfilePic(ProfilePicName, UserId);

                return View();
            }
            catch (Exception)
            {
                return View();

            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Rate(RateVM model)
         {
            try
            {
                rateRep.Create(model);
                var RatedUser = await userManager.FindByIdAsync(model.UserId);
                var rateCount = rateRep.Get(a => a.UserId == model.UserId).Count();
                var rateVoteValue = rateRep.Get(a => a.UserId == model.UserId);
                var VoteValues = 0m;
                var FinalRate = 0m;
                if (rateCount > 0)
                {
                    foreach (var RateValue in rateVoteValue)
                    {
                        VoteValues += RateValue.Value;
                    }
                    FinalRate = Math.Floor(VoteValues / rateCount);
                    RatedUser.Rate = Convert.ToInt16(FinalRate);
                    await userRep.Edit(RatedUser);

                }
                return RedirectToAction("VisitProfile", new RouteValueDictionary(new { controller = "Home", action = "VisitProfile", SpecialistId = model.UserId }));
            }
            catch (Exception)
            {
                return RedirectToAction("VisitProfile", new RouteValueDictionary(new { controller = "Home", action = "VisitProfile", SpecialistId = model.UserId }));

            }
        }

    }
}