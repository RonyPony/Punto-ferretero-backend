using PUNTO_FERRETERO.DATA.CONTEXT;
using PUNTO_FERRETERO.DATA.CONTRACT;
using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.REPOSITORY
{
    public class ProductRepository : IProductRepository
    {
        private readonly PUNTO_FERRETEROContext _context;
        public ProductRepository(PUNTO_FERRETEROContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProduct(Product data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            Product Product = await _context.Products.FindAsync(id);
            Product.isDeleted = true;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            List <Product> Products = _context.Products.Where((e)=> !e.isDeleted).ToList();
            return Products;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            Product Product = await _context.Products.FindAsync(id);
            return Product;
        }

        public async Task<Product> UpdateProduct(Product data)
        {
            _context.Products.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
