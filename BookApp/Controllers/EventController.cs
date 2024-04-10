using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Helper;
using Microsoft.AspNetCore.Http;
using Services.Interface;
using Microsoft.AspNetCore.Authorization;

namespace BookApp.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventBL _eventBl;

        public EventController(IEventBL eventBL)
        {
            _eventBl = eventBL;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEvent(EventModel userEvent)
        {
             Event evt = new EventModelToEventHelper().EventModelToEventMapping(userEvent);
            if (ModelState.IsValid)
            {
                evt.UserId = HttpContext.Session.GetString("username"); 

               

                if (_eventBl.CreateEvent(evt))
                     return RedirectToAction("Index", "Home");


            }
            //ViewBag.Message = "Some Problem Occured while creating the event";
            return View();
            
        }
        public IActionResult AllEvents()
        {
            IEnumerable<Event> events = _eventBl.GetAllEvent();

            return View(new EventToEventModelHelper().GetEventModels(events));

        }

        public IActionResult MyEvents()
        {
            string UserName = HttpContext.Session.GetString("username");
            var myEvents = _eventBl.GetMyEvents(UserName);
            return View(new EventToEventModelHelper().GetEventModels(myEvents));
        }


        public IActionResult EventsInvitedTo()
        {
            string UserEmail = HttpContext.Session.GetString("userEmail");
            var invitedEvents = _eventBl.GetInvitedTo(UserEmail);
            return View(new EventToEventModelHelper().GetEventModels(invitedEvents));
        }
        

        [HttpGet]
        public IActionResult EditEvent(int eventId)
        {
            EventModel model = new EventToEventModelHelper().EventToEventModelMapping(_eventBl.GetAnEvent(eventId));
            return View(model);
        }

        [HttpPost]
        public IActionResult EditEvent(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                var evt = new EventModelToEventHelper().EventModelToEventMapping(eventModel);
                evt.EventId =eventModel.EventId;
                evt.UserId= HttpContext.Session.GetString("username");

                var test= _eventBl.EditEvent(evt);

                if (test)
                {
                    return RedirectToAction("MyEvents");
                }
                return RedirectToAction("ViewEvent", new { eventModel.EventId });
            }
            else
                return View();

        }

        public IActionResult ViewEvent(int eventId)
        {
            EventModel eventModel = new EventToEventModelHelper().EventToEventModelMapping(_eventBl.GetAnEvent(eventId));
            return View(eventModel);
        }

    }
}
