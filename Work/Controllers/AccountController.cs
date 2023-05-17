using Work.DAL.Extend;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Work.BL.Models;
using Microsoft.AspNetCore.Authorization;
using Work.BL.Interface;
using Work.BL.Models;
using Work.BL.Helper;

namespace Work.Controllers
{
    public class AccountController : Controller
    {
        #region Fields
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IRolesRep role;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IUserRep userRep;
        #endregion

        #region Ctor
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IRolesRep role, RoleManager<IdentityRole> roleManager, IUserRep userRep)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.role = role;
            this.roleManager = roleManager;
            this.userRep = userRep;
        }
        #endregion


        #region Register

        [HttpGet]
        public IActionResult Register(string role)
        {
            ViewBag.RegisterAs = role;
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
                    };
                    var AddUser = await userManager.CreateAsync(user, obj.Password);

                    if (AddUser.Succeeded)
                    {
                        var CreatedUser = await userManager.FindByEmailAsync(obj.Email);
                        var userVM = new UserInRoleVM()
                        {
                            UserId = CreatedUser.Id,
                            RoleName = obj.RegisterAs,
                        };
                        await role.AddRoleToUser(userVM);

                        var RedirectLog = await signInManager.PasswordSignInAsync(obj.Email, obj.Password, true, false);

                        if (RedirectLog.Succeeded)
                        { 
                            return RedirectToAction("ProfileSettings");
                        }
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
        public async Task<IActionResult> Login()
        {
            var Auth = signInManager.IsSignedIn(User);
            if (Auth == true) 
            {
                var AuthUser = await userManager.FindByEmailAsync(User.Identity.Name);
                return RedirectToAction("HomePage", new RouteValueDictionary(new { controller = "Home", action = "HomePage", UserId = AuthUser.Id }));

            }

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
                        TempData["UserId"] = User.Id;
                        return RedirectToAction("HomePage", new RouteValueDictionary(new { controller = "Home", action = "HomePage", UserId = User.Id }));

                        //return RedirectToAction("HomePage", "Home");
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

        #region Edit User Data

        [HttpGet]
        public IActionResult ProfileSettings()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUser obj) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await userRep.Edit(obj);
                    return View("ProfileSettings");

                }
                ViewData["FailedEditing"] = "Failed To Edit";
                return View("ProfileSettings");
            }
            catch (Exception)
            {
                ViewData["FailedEditing"] = "Invalid Data";

                return View("ProfileSettings");
            }
        }

        #endregion


        #region Change Password
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ResetPasswordVM obj) 
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByIdAsync(obj.Id);
                    var CheckPassword = await signInManager.PasswordSignInAsync(user, obj.OldPassword, true, false);

                    if (CheckPassword.Succeeded)
                    {
                        var token = await userManager.GeneratePasswordResetTokenAsync(user);
                        var result = await userManager.ResetPasswordAsync(user, token, obj.NewPassword);

                        if (result.Succeeded)
                        {
                            return View();
                        }

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

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


        #region Forget Password
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM model)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    // Get User By Email
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {

                        // Generate Token
                        var token = await userManager.GeneratePasswordResetTokenAsync(user);

                        // Generate Reset Link
                        var passwordResetLink = Url.Action("ResetPassword", "Account", new { Email = model.Email, Token = token }, Request.Scheme);

                        MailSender.SendMail(new MailVM() { Mail = model.Email, Title = "Reset Password", Message = passwordResetLink });

                        return RedirectToAction("ConfirmForgetPassword");
                    }

                }

                return View(model);

            }
            catch (Exception)
            {
                return View(model);
            }

        }

        [HttpGet]
        public IActionResult ConfirmForgetPassword()
        {
            return View();
        }


        #endregion


        #region Reset Password
        [HttpGet]
        public IActionResult ResetPassword(string Email, string Token)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {
                        var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);

                        if (result.Succeeded)
                        {
                            return RedirectToAction("Login");
                        }

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        return View(model);
                    }

                    return View(model);

                }

                return View(model);

            }
            catch (Exception)
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ConfirmResetPassword()
        {
            return View();
        }

        #endregion

    }
}
