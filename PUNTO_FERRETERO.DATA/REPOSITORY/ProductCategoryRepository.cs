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
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly PUNTO_FERRETEROContext _context;
        public ProductCategoryRepository(PUNTO_FERRETEROContext context)
        {
            _context = context;
        }

        public async Task<ProductCategory> CreateProductCategory(ProductCategory data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteProductCategory(Guid id)
        {
            ProductCategory ProductCategory = await _context.ProductCategory.FindAsync(id);
            ProductCategory.isDeleted = true;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<ProductCategory> GetAllProductCategorys()
        {
            List <ProductCategory> data = _context.ProductCategory.Where((e)=> !e.isDeleted).ToList();
            return data;
        }

        public async Task<ProductCategory> GetProductCategoryById(Guid id)
        {
            ProductCategory data = await _context.ProductCategory.FindAsync(id);
            return data;
        }

        public async Task<ProductCategory> UpdateProductCategory(ProductCategory data)
        {
            _context.ProductCategory.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
