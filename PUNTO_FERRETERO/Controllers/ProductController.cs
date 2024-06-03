using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUNTO_FERRETERO.DATA.MODELS;
using PUNTO_FERRETERO.DATA.DTO;
using PUNTO_FERRETERO.CORE.SERVICES;
using PUNTO_FERRETERO.CORE.INTERFACE;
using System;

namespace PUNTO_FERRETERO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService serv)
        {
            _ProductService = serv;
        }

        [AllowAnonymous]
        [HttpPost("Product")]
        public async Task<IActionResult> createProductAsync([FromBody] ProductDTO value)
        {
            Product newProduct = new Product();
            newProduct.description = value.description;
            newProduct.productName = value.productName;
            newProduct.itenCount = value.itenCount;
            newProduct.productCategoryId = value.productCategoryId;
            newProduct.discount = value.discount;
            newProduct.updatedDate = DateTime.Now;
            newProduct.createdDate = DateTime.Now;
            newProduct.isDeleted = false;

            Product returningValue = await _ProductService.CreateProduct(newProduct);


            return Ok(returningValue);


        }

        // GET: api/<TicketController>
        [HttpGet("Product")]
        public IEnumerable<Product> Get()
        {


            return _ProductService.GetAllProducts();
        }

        [HttpGet("Product/{id}")]
        public async Task<Product> GetAsync(Guid id)
        {
            return await _ProductService.GetProductById(id);
        }


        [HttpPut("Product/{id}")]
        public async Task PutAsync(Guid id, [FromBody] ProductDTO value)
        {
            Product newPlan = new Product();
            newPlan = await _ProductService.GetProductById(id);
            newPlan.description = value.description;
            newPlan.productName = value.productName;
            newPlan.itenCount = value.itenCount;
            newPlan.discount = value.discount;
            newPlan.productCategoryId= value.productCategoryId;
            newPlan.updatedDate = DateTime.Now;
            _ProductService.UpdateProduct(newPlan);

        }


        [HttpDelete("Product/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            bool deleted = await _ProductService.DeleteProduct(id);
            if (deleted)
            {
                return BadRequest("Could not delete this product");
            }
            else
            {
                return Ok("deleted");
            }
        }

    }
}
