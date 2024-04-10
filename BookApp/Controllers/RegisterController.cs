using BookApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Helper;
using Services;
using Services.Interface;

namespace BookApp.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserBL _userBl;

        public RegisterController(IUserBL userBl)
        {
            _userBl = userBl;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserModel regUser)
        {

                User user = new RegisterUserModelToUserHelper().RegisterUserModelToUserMapping(regUser);
                if (ModelState.IsValid)
                {
                  if(await _userBl.AddUser(user))
                    return RedirectToAction("Login", "Login");
                }
            ViewBag.Message = "UserName or EmailId already exist";
            return View();
            }
            
        }
}


