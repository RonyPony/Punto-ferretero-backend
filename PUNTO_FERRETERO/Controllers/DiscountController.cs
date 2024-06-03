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
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _DiscountService;

        public DiscountController(IDiscountService serv)
        {
            _DiscountService = serv;
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> createDiscountAsync([FromBody] DiscountDTO value)
        {
            Discount newDiscount = new Discount();

            newDiscount.discountName = value.discountName;
            newDiscount.discountPorcentage = value.discountPorcentage;
            newDiscount.discountTotal = value.discountTotal;
            newDiscount.discountCode = value.discountCode;
            newDiscount.isDeleted = false;
            newDiscount.createdDate = DateTime.Now;
            newDiscount.updatedDate = DateTime.Now;
            

            Discount returningValue = await _DiscountService.CreateDiscount(newDiscount);


            return Ok(returningValue);


        }

        [HttpGet]
        public IEnumerable<Discount> Get()
        {


            return _DiscountService.GetAllDiscounts();
        }

        [HttpGet("{id}")]
        public async Task<Discount> GetAsync(Guid id)
        {
            return await _DiscountService.GetDiscountById(id);
        }


        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] DiscountDTO value)
        {
            Discount newPlan = new Discount();
            newPlan.discountName = value.discountName;
            newPlan.updatedDate = DateTime.Now;
            newPlan.discountCode = value.discountCode;
            newPlan.discountPorcentage = value.discountPorcentage;
            newPlan.discountTotal = value.discountTotal;
            newPlan = await _DiscountService.GetDiscountById(id);
            
            
            newPlan.updatedDate = DateTime.Now; 
            _DiscountService.UpdateDiscount(newPlan);

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            bool deleted = await _DiscountService.DeleteDiscount(id);
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
