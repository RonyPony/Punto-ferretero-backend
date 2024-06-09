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
    public class SalesRepository : ISalesRepository
    {
        private readonly PUNTO_FERRETEROContext _context;
        public SalesRepository(PUNTO_FERRETEROContext context)
        {
            _context = context;
        }

        public async Task<Sales> CreateSales(Sales data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteSales(Guid id)
        {
            Sales Sales = await _context.Sales.FindAsync(id);
            Sales.isDeleted = true;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Sales> GetAllSales()
        {
            List <Sales> data = _context.Sales.Where((e)=> !e.isDeleted).ToList();
            return data;
        }

        public int GetLastSaleNumber()
        {
            Sales lastSale = _context.Sales.OrderBy(i => i.createdDate).Take(1).FirstOrDefault();
            if(lastSale == null) {
                return 0;
            }
            var lastSaleNumber = lastSale.salesNumer;
            
            return lastSaleNumber;
        }

        public async Task<Sales> GetSalesById(Guid id)
        {
            Sales data = await _context.Sales.FindAsync(id);
            return data;
        }

        public async Task<Sales> UpdateSales(Sales data)
        {
            _context.Sales.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
