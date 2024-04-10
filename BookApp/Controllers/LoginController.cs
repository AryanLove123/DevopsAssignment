using BookApp.Helper;
using BookApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserBL _userBl;

        public LoginController(IUserBL userBl)
        {
            _userBl = userBl;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel Loguser)
        {
            User user = new UserModelToUserHelper().UserModelToUserMapping(Loguser);

            if ( _userBl.UserExists(user))
            {
               var userEmail= _userBl.GetEmail(user);
                HttpContext.Session.SetString("username", user.UserName);
                HttpContext.Session.SetString("userEmail", userEmail);

                return RedirectToAction("index", "Home");

            }
            else
            {
                ViewBag.Message = "Invalid UserName or Password";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("userEmail");
            return RedirectToAction("Index", "Home");
        }

    }
}
