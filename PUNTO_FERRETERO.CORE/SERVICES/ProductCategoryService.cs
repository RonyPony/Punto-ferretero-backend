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
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _repo;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository)
        {
            _repo = ProductCategoryRepository;
        }
        public IProductCategoryRepository Get_repo()
        {
            return _repo;
        }

        public async Task<ProductCategory> CreateProductCategory(ProductCategory data)
        {  
            try
            {
                await _repo.CreateProductCategory(data);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteProductCategory(Guid id)
        {
            try
            {
                return _repo.DeleteProductCategory(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ProductCategory> GetAllProductCategorys()
        {
            try
            {
                return _repo.GetAllProductCategorys();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ProductCategory> GetProductCategoryById(Guid id)
        {
            try
            {
                return _repo.GetProductCategoryById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ProductCategory> UpdateProductCategory(ProductCategory data)
        {
            try
            {
                return _repo.UpdateProductCategory(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
