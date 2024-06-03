using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.INTERFACE
{
    public interface IDiscountService
    {
        public IEnumerable<Discount> GetAllDiscounts();
        public Task<Discount> GetDiscountById(Guid id);
        public Task<Discount> CreateDiscount(Discount data);
        public Task<Discount> UpdateDiscount(Discount data);
        public Task<bool> DeleteDiscount(Guid id);
    }
}


