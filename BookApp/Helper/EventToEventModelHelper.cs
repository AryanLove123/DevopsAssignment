using BookApp.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Helper
{
    public class EventToEventModelHelper
    {
        public EventModel EventToEventModelMapping(Event e)
        {
            EventModel evt = new EventModel();
            evt.EventId = e.EventId;
            evt.UserId = e.UserId;
            evt.Title = e.Title;
            evt.Date = e.Date;
            evt.Location = e.Location;
            evt.StartTime = e.StartTime;
            evt.IsPrivate = e.IsPrivate;
            evt.Duration =(int) e.Duration;
            evt.Description = e.Description;
            evt.OtherDetails = e.OtherDetails;
            evt.InviteByEmail = e.InviteByEmail;
            return evt;
        }

        public IEnumerable<EventModel> GetEventModels(IEnumerable<Event> events)
        {
            List<EventModel> eventModels = new List<EventModel>();
            foreach (var item in events)
            {
                eventModels.Add(EventToEventModelMapping(item));
            }
            return eventModels;
        }
    }
}
