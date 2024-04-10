using DAL.Interfaces;
using Services.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EventBL :IEventBL
    {
        private readonly IEventDAL _eventDal;

        public EventBL(IEventDAL eventDal)
        {
            _eventDal = eventDal;
        }

        public IEnumerable<Event> GetAllEvent()
        {
            IEnumerable<Event> events = _eventDal.GetEvents();

            return events;
        }

        public Event GetAnEvent(int eventId)
        {
            return _eventDal.GetAnEvent(eventId);
        }

        public IEnumerable<Event> GetMyEvents(string userName)
        {
            IEnumerable<Event> myEvents = _eventDal.GetMyEvents(userName);
            return myEvents;
        }
        public IEnumerable<Event> GetInvitedTo(string userEmail)
        {
            IEnumerable<Event> invitedToEvents = _eventDal.GetInvitedTo(userEmail);

            return invitedToEvents;

        }
        public bool EditEvent(Event evt)
        {
            List<Invitation> invitations = new List<Invitation>();

            if (evt.InviteByEmail != null)
            {
                var invited = evt.InviteByEmail.Split(',');
                
                if (invited != null)
                {
                    foreach (var item in invited)
                    {
                        Invitation invitation = new Invitation();
                        invitation.Email = item;
                        invitation.EventId = evt.EventId;
                        invitations.Add(invitation);
                    }
                }
            }
            return _eventDal.EditEvent(evt, invitations);
        }
        public bool CreateEvent(Event evt)
        {
            IEnumerable<Event> events = _eventDal.GetEvents();

            var queryTitle = (from e in events
                              where e.Title.Equals(evt.Title, StringComparison.OrdinalIgnoreCase)
                              select e).ToList().Count;
            if (queryTitle == 0)
            {
                List<Invitation> invitations = new List<Invitation>();

                if (evt.InviteByEmail != null)
                {
                    var invited = evt.InviteByEmail.Split(',');
                  
                    if (invited != null)
                    {
                        foreach (var item in invited)
                        {
                            Invitation invitation = new Invitation();
                            invitation.Email = item;
                            invitation.EventId = evt.EventId;
                            invitations.Add(invitation);
                        }
                    }
                }
                _eventDal.CreateEvent(evt, invitations);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
