﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Deezer.Data.Entities;
using Deezer.Data.Models;
using Deezer.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Deezer.Controllers
{// GET: /<controller>/
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly IEmailSender _myEmailSender;
        private readonly EFContext _context;

        public AccountController(UserManager<DbUser> userManager, SignInManager<DbUser> signInManager, IEmailSender myEmailSender, EFContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _myEmailSender = myEmailSender;
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserProfile userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    RegistrationDate = DateTime.Now
                };
                DbUser user = new DbUser
                {
                    Email = model.Email,
                    UserName = model.UserName,
                    UserProfile = userProfile
                };
                if (_userManager.FindByEmailAsync(user.Email).Result != null)
                {
                    ModelState.AddModelError(string.Empty, "this Email is registred");
                    return View(model);
                }
                var rolename = "Artist";
                var result = await _userManager.CreateAsync(user, model.Password);
                result = _userManager.AddToRoleAsync(user, rolename).Result;

               
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if(user == null)
            {
                ModelState.AddModelError("","This Email not registred");
                return View(model);
            }
            var result = _signInManager
                .PasswordSignInAsync(user, model.Password, false, false).Result;
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Wrong Password");
                return View(model);
            }
            await _signInManager.SignInAsync(user, isPersistent: false);

            await Authenticate(model.Email);

            return RedirectToAction("Index", "Home");
        }
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "This Email not registred");
                return View(model);
            }
            //var userName = user.UserProfile.FirstName;
            await _myEmailSender.SendEmailAsync(model.Email, "ForgotPassword",
                $"Dear a," +
                $"<br/>" +
                $" To change your password " +
                $"<br/>" +
                $" You should visit this link <a href=''>change password</a>");

            return View(model);
        }
        [HttpGet]
        [Route("Account/ChangePassword/{id}")]
        public IActionResult ChangePassword(string id)
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult>ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
           
            return View(model);
        }
        

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
