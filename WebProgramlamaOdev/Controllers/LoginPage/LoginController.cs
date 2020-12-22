using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers.LoginPage
{
    public class LoginController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(User user)
        {
            var userInfo = context.USER.FirstOrDefault(x => x.USER_MAIL == user.USER_MAIL && x.USER_PASSWORD == user.USER_PASSWORD);
            if (userInfo != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.USER_MAIL)
                };
                
                var userIdentity = new ClaimsIdentity(claims, "User");
                
                if (userInfo.USER_ISADMIN == true)
                {
                    userIdentity = new ClaimsIdentity(claims, "Admin");
                }

               
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public JsonResult NewUser(User user)
        {
            string exceptionMessage = "";
            try
            {
                context.USER.Add(user);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
            }

            if (exceptionMessage != "")
            {
                return Json(exceptionMessage);
            }
            else
            {
                return Json("başarılı");
            }


        }
    }
}
