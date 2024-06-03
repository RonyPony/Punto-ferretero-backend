
using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.INTERFACE
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts();
        public Task<Product> GetProductById(Guid id);
        public Task<Product> CreateProduct(Product data);
        public Task<Product> UpdateProduct(Product data);
        public Task<bool> DeleteProduct(Guid id);
    }
}


