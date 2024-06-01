using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUNTO_FERRETERO.DATA.MODELS;
using PUNTO_FERRETERO.DATA.DTO;
using PUNTO_FERRETERO.CORE.SERVICES;
using PUNTO_FERRETERO.CORE.INTERFACE;

namespace PUNTO_FERRETERO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UserController(IUserService serv)
        {
            _UserService = serv;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> createUserAsync([FromBody] UserDTO value)
        {
            User newUser = new User();
            newUser.name = value.name;
            newUser.lastName = value.lastName;
            newUser.isDeleted = false;
            newUser.createdDate = DateTime.Now;
            newUser.updatedDate = DateTime.Now;
            newUser.password = value.password;

            User returningValue = await _UserService.CreateUser(newUser);


            return Ok(returningValue);


        }

        [HttpGet]
        public IEnumerable<User> Get()
        {


            return _UserService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<User> GetAsync(Guid id)
        {
            return await _UserService.GetUserById(id);
        }


        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] UserDTO value)
        {
            User newPlan = new User();
            newPlan = await _UserService.GetUserById(id);
            
            newPlan.name = value.name;
            newPlan.lastName = value.lastName;
            newPlan.password = value.password;
            newPlan.updatedDate = DateTime.Now; 
            _UserService.UpdateUser(newPlan);

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            bool deleted = await _UserService.DeleteUser(id);
            if (deleted)
            {
                return BadRequest("Could not delete this");
            }
            else
            {
                return Ok("deleted");
            }
        }

    }
}
