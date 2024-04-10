using BookApp.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Helper
{
    public class RegisterUserModelToUserHelper
    {
        public User RegisterUserModelToUserMapping(RegisterUserModel e)
        {
            User u = new User();
            u.EmailId = e.EmailId;
            u.UserName = e.UserName;
            u.Password = e.Password;
            return u;
        }
    }
}
