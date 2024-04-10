using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interface
{
    public interface IEventBL
    {
        public IEnumerable<Event> GetAllEvent();
        public Event GetAnEvent(int eventId);
        public IEnumerable<Event> GetMyEvents(string userName);
        public IEnumerable<Event> GetInvitedTo(string userEmail);
        public bool EditEvent(Event evt);
        public bool CreateEvent(Event evt);

    }
}
