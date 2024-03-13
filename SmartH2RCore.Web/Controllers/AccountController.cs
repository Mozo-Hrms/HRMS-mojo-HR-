using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

using SmartH2RCore.Models.DTO;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Web.Controllers;
using SmartH2RCore.Web.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Controllers
{

    public class AccountController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController( UserManager<User> userManager,SignInManager<User> signInManager )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                TempData["Success"] = false;
                TempData["Message"] = "Please enter valid email or password";
                return View(model);
            }
            return View(model);
        }
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(LoginDTO model, string returnUrl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: false);
        //        if (result.Succeeded)
        //        {
        //            //logger.LogInformation("User Logged in successful");
        //            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
        //            {
        //                return LocalRedirect(returnUrl);
        //            }
        //            else
        //            {
        //                return RedirectToAction("Index", "Dashboard");
        //            }

        //        }
        //        //TempData["Success"] = false;
        //        //TempData["Message"] = "Please enter valid email or password";
        //        //return View(model);
        //        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        //    }
        //    return View(model);
        //}
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(SignupModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                  
                };
                var result = _userManager.CreateAsync(user, model.Password).Result;
                if (result.Succeeded)
                {
                    _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                return View(model);
            }

            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            ModelState.AddModelError(string.Empty, allErrors.FirstOrDefault().ErrorMessage);
            return View(model);
        }
        // Below code is for register this is new register controller , it has error

        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
        //        var result = await _userManager.CreateAsync(user, model.Password);

        //        if (result.Succeeded)
        //        {
        //            await _signInManager.SignInAsync(user, isPersistent: false);
        //            return RedirectToAction("Index", "Home");
        //        }

        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }

        //    return View(model);
        //}
        [Route("change-password")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Route("change-password"),HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.Password);
            if (!result.Succeeded)
            {
                TempData["Message"] = result.Errors.FirstOrDefault()?.Description;
                TempData["Success"] = false;
                return View();
            }
            TempData["Message"] = "Password Changed Successfully!";
            TempData["Success"] = true;
            return View();
        }
    }
}