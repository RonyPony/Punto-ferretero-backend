using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.CORE.INTERFACE
{
    public interface ISalesService
    {
        public IEnumerable<Sales> GetAllSales();
        public Task<Sales> GetSalesById(Guid id);
        public Task<Sales> CreateSales(Sales data);
        public Task<Sales> UpdateSales(Sales data);
        public Task<bool> DeleteSales(Guid id);
    }
}


