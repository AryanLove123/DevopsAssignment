using Shared;
using System;
using System.Collections.Generic;
using DAL;
using DAL.Interfaces;
using System.Linq;
using Services.Interface;
using System.Threading.Tasks;

namespace Services
{
    public class UserBL : IUserBL
    {
        private readonly IUsersDAL _userDal;

        public UserBL(IUsersDAL userDal)
        {
            _userDal = userDal;
        }

        public async Task<bool> AddUser(User user)
        {
            IEnumerable<User> users = await _userDal.GetUsers();
            int count = (from u in users
                         where (u.EmailId == user.EmailId) || (u.UserName == user.UserName)
                         select u).ToList().Count();
            if (count == 0)
            {
                _userDal.AddUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }
        public String GetEmail(User user)
        {
            var userEmail=_userDal.GetEmail(user);
            return userEmail;
        }

        public bool UserExists(User user)
        {
            if (_userDal.IsValid(user))
                return true;
            else
                return false;
        }
    }
}
