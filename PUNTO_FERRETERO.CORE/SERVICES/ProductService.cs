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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository ProductRepository)
        {
            _repo = ProductRepository;
        }
        public IProductRepository Get_repo()
        {
            return _repo;
        }

        public async Task<Product> CreateProduct(Product data)
        {  
            try
            {
                await _repo.CreateProduct(data);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteProduct(Guid id)
        {
            try
            {
                return _repo.DeleteProduct(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return _repo.GetAllProducts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Product> GetProductById(Guid id)
        {
            try
            {
                return _repo.GetProductById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Product> UpdateProduct(Product data)
        {
            try
            {
                return _repo.UpdateProduct(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
