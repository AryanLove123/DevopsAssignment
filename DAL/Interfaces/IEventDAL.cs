using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
   public interface IEventDAL
    {
        public IEnumerable<Event> GetEvents();
        public Event GetAnEvent(int eventId);
        public IEnumerable<Event> GetMyEvents(string userName);
        public IEnumerable<Event> GetInvitedTo(string userEmail);
        public bool EditEvent(Event evt, List<Invitation> invitations);
        public void CreateEvent(Event evt, List<Invitation> invitations);
    }
}
