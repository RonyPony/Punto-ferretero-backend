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
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryService _ProductCategoryService;

        public ProductCategoryController(IProductCategoryService serv)
        {
            _ProductCategoryService = serv;
        }

        [AllowAnonymous]
        [HttpPost("ProductCategory")]
        public async Task<IActionResult> createProductCategoryAsync([FromBody] ProductCategoryDTO value)
        {
            ProductCategory newProductCategory = new ProductCategory();
            newProductCategory.productcategoryName = value.productcategoryName;
            newProductCategory.productcategoryDescription = value.productcategoryDescription;
            newProductCategory.isDeleted = false;
            newProductCategory.updatedDate = DateTime.Now;
            newProductCategory.createdDate = DateTime.Now;

            ProductCategory returningValue = await _ProductCategoryService.CreateProductCategory(newProductCategory);


            return Ok(returningValue);


        }

        // GET: api/<TicketController>
        [HttpGet("ProductCategory")]
        public IEnumerable<ProductCategory> Get()
        {


            return _ProductCategoryService.GetAllProductCategorys();
        }

        [HttpGet("ProductCategory/{id}")]
        public async Task<ProductCategory> GetAsync(Guid id)
        {
            return await _ProductCategoryService.GetProductCategoryById(id);
        }


        [HttpPut("ProductCategory/{id}")]
        public async Task PutAsync(Guid id, [FromBody] ProductCategoryDTO value)
        {
            ProductCategory newPlan = new ProductCategory();
            newPlan = await _ProductCategoryService.GetProductCategoryById(id);
            newPlan.productcategoryName = value.productcategoryName;
            newPlan.productcategoryDescription = value.productcategoryDescription;
            newPlan.updatedDate = DateTime.Now;

             _ProductCategoryService.UpdateProductCategory(newPlan);

        }


        [HttpDelete("ProductCategory/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            bool deleted = await _ProductCategoryService.DeleteProductCategory(id);
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
