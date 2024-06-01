using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.INTERFACE
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();
        public Task<User> GetUserById(Guid id);
        public Task<User> CreateUser(User data);
        public Task<User> UpdateUser(User data);
        public Task<bool> DeleteUser(Guid id);
    }
}


