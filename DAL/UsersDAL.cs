using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DAL
{
    public class UsersDAL:IUsersDAL
    {
        private readonly BookReadingContext _context;

        public UsersDAL(BookReadingContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            IEnumerable<User> users = await _context.Users.ToListAsync();
            return users;
        }

        public void AddUser(User user)
        {
            if (user.EmailId == "myadmin@bookevents.com")
                user.Isadmin = true;
            else
                user.Isadmin = false;

            _context.Users.Add(user);
            _context.SaveChanges();
               
        }

        public async Task<bool> UserExists(User user)
        {
            var query =await (_context.Users.FirstOrDefaultAsync(u=>u.UserName==user.UserName));

            if (query != null)
            {
                return true;
            }
            return false;
        }

        public String GetEmail(User user)
        {
             var query = (_context.Users.FirstOrDefault(u => u.UserName == user.UserName));
            var userEmail = query.EmailId;
            return userEmail;
        }
        public bool IsValid(User user)
        {
            var query = (_context.Users.FirstOrDefault(u => u.UserName==user.UserName && u.Password == user.Password));
            if (query != null)
            {
                return true;
            }
            return false;
        }
    }
}


