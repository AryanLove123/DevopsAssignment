using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUsersDAL
    {
        public Task<IEnumerable<User>> GetUsers();
        public void AddUser(User user);
        public Task<bool> UserExists(User user);
        public String GetEmail(User user);
        public bool IsValid(User user);
    }
}
