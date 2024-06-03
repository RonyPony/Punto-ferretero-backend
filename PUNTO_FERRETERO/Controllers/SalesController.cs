using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUNTO_FERRETERO.DATA.MODELS;
using PUNTO_FERRETERO.DATA.DTO;
using PUNTO_FERRETERO.CORE.SERVICES;
using PUNTO_FERRETERO.CORE.INTERFACE;
using ferreteiaAPI.Models;

namespace PUNTO_FERRETERO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _SalesService;

        public SalesController(ISalesService serv)
        {
            _SalesService = serv;
        }

        [AllowAnonymous]
        [HttpPost("Sales")]
        public async Task<IActionResult> createSalesAsync([FromBody] SalesDTO value)
        {
            Sales newSales = new Sales();
            

            Sales returningValue = await _SalesService.CreateSales(newSales);


            return Ok(returningValue);


        }

        // GET: api/<TicketController>
        [HttpGet("Sales")]
        public IEnumerable<Sales> Get()
        {

            return _SalesService.GetAllSales();
        }

        [HttpGet("Sales{id}")]
        public async Task<Sales> GetAsync(Guid id)
        {
            return await _SalesService.GetSalesById(id);
        }


        [HttpPut("Sales/{id}")]
        public async Task PutAsync(Guid id, [FromBody] SalesDTO value)
        {
            Sales newPlan = new Sales();
            newPlan = await _SalesService.GetSalesById(id);
            
            
            newPlan.updatedDate = DateTime.Now; 
            _SalesService.UpdateSales(newPlan);

        }


        [HttpDelete("Sales/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            bool deleted = await _SalesService.DeleteSales(id);
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
