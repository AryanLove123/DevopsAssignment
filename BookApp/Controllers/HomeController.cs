using BookApp.Helper;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEventBL _eventBl;
        public HomeController(ILogger<HomeController> logger, IEventBL eventBL)
        {
            _logger = logger;
            _eventBl = eventBL;
        }

        public IActionResult Index()
        {
            var eventListMain = _eventBl.GetAllEvent();
            var evt = new EventToEventModelHelper().GetEventModels(eventListMain);
            return View(evt);
        }
        public IActionResult suc()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
