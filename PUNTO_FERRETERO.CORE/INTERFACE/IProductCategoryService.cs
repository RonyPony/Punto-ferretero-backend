using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.INTERFACE
{
    public interface IProductCategoryService
    {
        public IEnumerable<ProductCategory> GetAllProductCategorys();
        public Task<ProductCategory> GetProductCategoryById(Guid id);
        public Task<ProductCategory> CreateProductCategory(ProductCategory data);
        public Task<ProductCategory> UpdateProductCategory(ProductCategory data);
        public Task<bool> DeleteProductCategory(Guid id);
    }
}


