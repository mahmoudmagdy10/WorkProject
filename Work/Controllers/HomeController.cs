using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Work.Models;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterAs()
        {
            return View();
    
        }

        [Authorize]
        public IActionResult HomePage(string UserId)
        {
            TempData["UserId"] = UserId;
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

    }
}