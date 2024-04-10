using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
   public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string EmailId { get; set; }
        public string Password { get; set; }

        public bool Isadmin { get; set; }
        public virtual ICollection<Event> Events { get; set; }
       
    }
}
