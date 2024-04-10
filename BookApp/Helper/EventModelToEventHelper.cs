using BookApp.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Helper
{
    public class EventModelToEventHelper
    {
        public Event EventModelToEventMapping(EventModel e)
        {
            Event evt = new Event();
            evt.Title = e.Title;
            evt.Date = e.Date;
            evt.Location = e.Location;
            evt.StartTime = e.StartTime;
            evt.IsPrivate = e.IsPrivate;
            evt.Duration = e.Duration;
            evt.Description = e.Description;
            evt.OtherDetails = e.OtherDetails;
            evt.InviteByEmail = e.InviteByEmail;
            return evt;
        }
    }
}
