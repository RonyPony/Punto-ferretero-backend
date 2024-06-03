using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.DTO
{
    public class ProductDTO
    {
        public string productName { get; set; }
        public Guid productCategoryId { get; set; }
        public string productcategoryName { get; set; }
        public int itenCount { get; set; }
        public string description { get; set; }
        public Guid discount { get; set; }
        public string discountCode { get; set; }
        public string discountName { get; set; }
    }
}

