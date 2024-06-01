using PUNTO_FERRETERO.DATA.CONTEXT;
using PUNTO_FERRETERO.DATA.CONTRACT;
using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.REPOSITORY
{
    public class UserRepository : IUserRepository
    {
        private readonly PUNTO_FERRETEROContext _context;
        public UserRepository(PUNTO_FERRETEROContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUser(User data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            User user = await _context.users.FindAsync(id);
            user.isDeleted = true;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List <User> users = _context.users.Where((e)=> !e.isDeleted).ToList();
            return users;
        }

        public async Task<User> GetUserById(Guid id)
        {
            User user = await _context.users.FindAsync(id);
            return user;
        }

        public async Task<User> UpdateUser(User data)
        {
            _context.users.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
