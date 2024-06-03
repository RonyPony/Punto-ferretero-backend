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
    public class DiscountRepository : IDiscountRepository
    {
        private readonly PUNTO_FERRETEROContext _context;
        public DiscountRepository(PUNTO_FERRETEROContext context)
        {
            _context = context;
        }

        public async Task<Discount> CreateDiscount(Discount data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteDiscount(Guid id)
        {
            Discount Discount = await _context.Discount.FindAsync(id);
            Discount.isDeleted = true;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Discount> GetAllDiscounts()
        {
            List <Discount> data = _context.Discount.Where((e)=> !e.isDeleted).ToList();
            return data;
        }

        public async Task<Discount> GetDiscountById(Guid id)
        {
            Discount data = await _context.Discount.FindAsync(id);
            return data;
        }

        public async Task<Discount> UpdateDiscount(Discount data)
        {
            _context.Discount.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
