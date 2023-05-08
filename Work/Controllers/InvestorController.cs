using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Interface;
using Work.DAL.Entity;
using Work.DAL.Extend;

namespace Work.Controllers
{
    public class InvestorController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserRep user;
        private readonly IProjectRep project;

        public InvestorController(UserManager<ApplicationUser> userManager, IUserRep user, IProjectRep project)
        {
            this.userManager = userManager;
            this.user = user;
            this.project = project;
        }

        [HttpGet]
        [Authorize(Roles = "Investor")]

        public IActionResult BuyProject()
        {
            var data = project.Get();
            return View(data);
        }

        [HttpGet]
        [Authorize(Roles = "Investor")]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Investor")]
        public IActionResult BillingInfo()
        {
            return View();
        }

    }
}
