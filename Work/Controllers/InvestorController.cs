using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Interface;
using Work.DAL.Extend;

namespace Work.Controllers
{
    public class InvestorController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserRep user;

        public InvestorController(UserManager<ApplicationUser> userManager, IUserRep user)
        {
            this.userManager = userManager;
            this.user = user;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(string RecieverEmail)
        {
            ViewBag.UserEmail = RecieverEmail;
            //ViewBag.User = User.Identity.Name;
            return View();
        }
    }
}
