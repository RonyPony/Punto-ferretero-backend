using PUNTO_FERRETERO.CORE.INTERFACE;
using PUNTO_FERRETERO.DATA.MODELS;
using PUNTO_FERRETERO.DATA.CONTRACT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.SERVICES
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository UserRepository)
        {
            _repo = UserRepository;
        }
        public IUserRepository Get_repo()
        {
            return _repo;
        }

        public async Task<User> CreateUser(User data)
        {  
            try
            {
                await _repo.CreateUser(data);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteUser(Guid id)
        {
            try
            {
                return _repo.DeleteUser(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return _repo.GetAllUsers();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<User> GetUserById(Guid id)
        {
            try
            {
                return _repo.GetUserById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<User> UpdateUser(User data)
        {
            try
            {
                return _repo.UpdateUser(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
