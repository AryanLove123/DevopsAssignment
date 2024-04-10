using BookApp.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Helper
{
    public class UserModelToUserHelper
    {
        public User UserModelToUserMapping(UserModel e)
        {
            User u = new User();
            u.UserName = e.UserName;
            u.Password = e.Password;
            return u;
        }
    }
}
