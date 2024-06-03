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
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _repo;

        public DiscountService(IDiscountRepository DiscountRepository)
        {
            _repo = DiscountRepository;
        }
        public IDiscountRepository Get_repo()
        {
            return _repo;
        }

        public async Task<Discount> CreateDiscount(Discount data)
        {  
            try
            {
                await _repo.CreateDiscount(data);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteDiscount(Guid id)
        {
            try
            {
                return _repo.DeleteDiscount(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Discount> GetAllDiscounts()
        {
            try
            {
                return _repo.GetAllDiscounts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Discount> GetDiscountById(Guid id)
        {
            try
            {
                return _repo.GetDiscountById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Discount> UpdateDiscount(Discount data)
        {
            try
            {
                return _repo.UpdateDiscount(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
