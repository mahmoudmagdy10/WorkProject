using Microsoft.AspNetCore.Mvc;
using Work.BL.Interface;
using Work.BL.Models;

namespace Work.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestRep requestRep;

        public RequestController(IRequestRep requestRep)
        {
            this.requestRep = requestRep;
        }

        [HttpPost]
        public IActionResult Edit(RequestVM model)
        {
            requestRep.Edit(model);
            return RedirectToAction("Profile", "Home");
        }

        [HttpPost]
        public IActionResult Delete(RequestVM model)
        {
            requestRep.Delete(model);
            return RedirectToAction("Profile", "Home");
        }
    }
}
