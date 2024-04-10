using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IUserBL
    {
        public Task<bool> AddUser(User user);
        public String GetEmail(User user);
        public bool UserExists(User user);
    }
}
