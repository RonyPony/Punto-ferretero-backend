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
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _repo;

        public SalesService(ISalesRepository SalesRepository)
        {
            _repo = SalesRepository;
        }
        public ISalesRepository Get_repo()
        {
            return _repo;
        }

        public async Task<Sales> CreateSales(Sales data)
        {  
            try
            {
                await _repo.CreateSales(data);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteSales(Guid id)
        {
            try
            {
                return _repo.DeleteSales(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Sales> GetAllSales()
        {
            try
            {
                return _repo.GetAllSales();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Sales> GetSalesById(Guid id)
        {
            try
            {
                return _repo.GetSalesById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Sales> UpdateSales(Sales data)
        {
            try
            {
                return _repo.UpdateSales(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
