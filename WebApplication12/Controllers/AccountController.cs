using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication12.BL.helper;
using WebApplication12.BL.VM;

namespace WebApplication12.Controllers
{
    public class AccountController : Controller
    {//using microsoft identity to achieve security 
        // private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly UserManager<IdentityUser> userman;
        private readonly SignInManager<IdentityUser> signman;
        private readonly ILogger<AccountController> logger;
      

        //for dependency injection
        public AccountController(UserManager<IdentityUser> userman, SignInManager<IdentityUser> signman, ILogger<AccountController> logger)
        {
this.userman = userman;
            this.signman = signman;
            this.logger = logger;
        }
        //register actions
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegistrationVM reg)

        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser();
                user.Email = reg.mail;
                user.UserName = reg.mail;
                var res= await userman.CreateAsync(user,reg.password);
                if (res.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {foreach(var error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
               
            }
            return View(reg);
        }


        //****************************************************************************

        //login actions
        public IActionResult Login()
        {
         
            return View();
        }


        [HttpPost]
        public  async Task<IActionResult> Login(LoginVM log)
        {
            if (ModelState.IsValid)
            {
                var result = await signman.PasswordSignInAsync(log.mail, log.password, log.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserName Or Password Attempt");

                }


            }

            return View(log);




        }

        //****************************************************************************

        //forgetpassword  actions
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userman.FindByEmailAsync(model.mail);

                if (user != null)
                {
                    var token = await userman.GeneratePasswordResetTokenAsync(user);

                    var passwordResetLink = Url.Action("ResetPassword", "Account", new { Email = model.mail, Token = token }, Request.Scheme);

                    MailHelper.sendMailAsync("Password Reset Link", passwordResetLink,model.mail);



                    return RedirectToAction("ConfirmReset");
                }
                else
                {
                    ViewBag.x = "mail is Invalid";
                    return View(model);
                }

              

            }

            return View(model);
        }
        //****************************************************************************
        //resetpassword  actions
        public IActionResult ResetPassword(string Email,string Token)
        {
            if (Email == null || Token == null)
            {
                ModelState.AddModelError("", "Invalid Data");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetpassword)
        {
            if (ModelState.IsValid)
            {
                var user = await userman.FindByEmailAsync(resetpassword.Email);

                if (user != null)
                {
                    var result = await userman.ResetPasswordAsync(user, resetpassword.Token, resetpassword.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(resetpassword);
                }

                return RedirectToAction("Login");
            }

            return View(resetpassword);
        }

        //****************************************************************************
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
           await  signman.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult ConfirmReset()
        {
            return View();
        }

    }
}
