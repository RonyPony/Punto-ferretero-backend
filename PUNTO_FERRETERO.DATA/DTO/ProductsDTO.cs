using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.DTO
{
    internal class ProductsDTO
    {
        public string productName { get; set; }
        public Guid productCategoryId { get; set; }
        public int itenCount { get; set; }
        public DateTime updatedDate { get; set; }
        public string description { get; set; }
        public Guid discount { get; set; }
    }
}

