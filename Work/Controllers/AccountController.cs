using Work.DAL.Extend;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Models;
using Microsoft.AspNetCore.Authorization;

namespace Work.Controllers
{
    public class AccountController : Controller
    {
        #region Fields
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        #endregion

        #region Ctor
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        #endregion


        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM obj)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var user = new ApplicationUser()
                    {

                        UserName = obj.Email,
                        Email = obj.Email,
                        IsAgree = obj.IsAgree
                    };

                    var AddUser = await userManager.CreateAsync(user, obj.Password);

                    if (AddUser.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var item in AddUser.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }

                return View(obj);
            }
            catch (Exception)
            {
                return View(obj);
            }
        }
        #endregion

        #region LogIn

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var User = await userManager.FindByEmailAsync(obj.Email);
                    var CheckPassword = await signInManager.PasswordSignInAsync(User, obj.Password, obj.RememberMe, false);

                    if (CheckPassword.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid UserName or Password");
                    }
                }

                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
        #endregion

        #region LogOff (Sign Out)

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


        #endregion

    }
}
