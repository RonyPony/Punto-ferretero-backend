using PUNTO_FERRETERO.CORE.INTERFACE;
using PUNTO_FERRETERO.DATA.MODELS;
using PUNTO_FERRETERO.DATA.CONTRACT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_FERRETERO.DATA.REPOSITORY;
using PUNTO_FERRETERO.DATA.DTO;

namespace PUNTO_FERRETERO.CORE.SERVICES
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IProductCategoryRepository _categoryRepository;
        private readonly IDiscountRepository _discountRepository;

        public ProductService(IProductRepository ProductRepository,
            IProductCategoryRepository productCategoryRepository, IDiscountRepository discountRepository
            )
        {
            _repo = ProductRepository;
            _categoryRepository = productCategoryRepository;
            _discountRepository = discountRepository;
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

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            try
            {
                var data = _repo.GetAllProducts();
                List<ProductDTO> deteo = new List<ProductDTO>();
                //int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
                foreach (Product product in data)
                {
                    ProductCategory cat = await _categoryRepository.GetProductCategoryById(product.productCategoryId);
                    Discount dis = await _discountRepository.GetDiscountById(product.discountId!.Value);
                    ProductDTO tmp = new ProductDTO {
                        description = product.description,
                        productCategoryId = product.productCategoryId,
                        itenCount = product.itenCount,
                        productName = product.productName,
                        discountCode = null,
                        discountId = null,
                        discountName = null,
                        productCategoryName = null
                    };
                
                    if (cat != null)
                    {
                        tmp.productCategoryName = cat.productcategoryName;
                    }
                    if (dis!= null)
                    {
                        tmp.discountCode = dis.discountCode;
                        tmp.discountName = dis.discountName;
                        tmp.discountId = dis.discountId;
                    }

                    deteo.Add(tmp);

                }
                
                return deteo;

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
