using Microsoft.AspNetCore.Mvc;

namespace Work.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult ChatRequests()
        {
            return View();
        }
        public IActionResult CreateChat(string RecieverEmail)
        {
            TempData["UserEmail"] = RecieverEmail;
            return View();
        }
    }
}
