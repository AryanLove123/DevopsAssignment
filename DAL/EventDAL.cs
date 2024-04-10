using DAL.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class EventDAL : IEventDAL
    {
        private readonly BookReadingContext _context;

        public EventDAL(BookReadingContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<Event> GetEvents()
        {
            IEnumerable<Event> events = _context.Events.ToList();
            return events;
                    
        }

        public Event GetAnEvent(int eventId)
        {

            IEnumerable<Event> events = GetEvents();
            Event eventFound=null;
            var query = from evt in events
                            where evt.EventId == eventId
                            select evt;
            if (query != null)
            {
                eventFound = query.ToList().FirstOrDefault();
            }
            return eventFound;            
        }
        public IEnumerable<Event> GetMyEvents(string userName)
        {
            var evt = (from e in _context.Events
                           where e.UserId == userName
                           select e).ToList();

            return evt;
        }

        public IEnumerable<Event> GetInvitedTo(string userEmail)
        {
            IEnumerable<Invitation> invitations = _context.Invitations;
            IEnumerable<Event> events = _context.Events;
            IEnumerable<Event> invitedTo = null;

                var query = from i in invitations
                            join e in events
                            on i.Email equals userEmail
                            where i.EventId == e.EventId
                            select e;
                if (query != null)
                {
                    invitedTo = query.ToList();
                }

                return invitedTo;
        }

        public bool EditEvent(Event evt, List<Invitation> invitations)
        {
            if (invitations != null)
            {
                var result = (from i in _context.Invitations
                              where i.EventId == evt.EventId
                              select i);

                _context.Invitations.RemoveRange(result.ToList());


                foreach (var item in invitations)
                {
                    item.EventId = evt.EventId;
                    _context.Invitations.Add(item);
                    _context.SaveChanges();
                }
            }
           
            _context.Events.Update(evt);
            _context.SaveChanges();
             return true;  
        }

        public void CreateEvent(Event evt, List<Invitation> invitations)
        {

                _context.Events.Add(evt);
                _context.SaveChanges();
                int id = evt.EventId;
                foreach (var item in invitations)
                {
                    item.EventId = id;
                    _context.Invitations.Add(item);
                    _context.SaveChanges();
            }
        }
    }
}
