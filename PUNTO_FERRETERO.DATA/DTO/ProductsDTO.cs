using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.DTO
{
    public class ProductDTO
    {
        public Guid productId { get; set; }
        public string productName { get; set; }
        public Guid productCategoryId { get; set; }
        public string? productCategoryName { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal buyingPrice { get; set; }
        public int itenCount { get; set; }
        public string description { get; set; }
        public Guid? discountId { get; set; }
        public string? discountCode { get; set; }
        public string? discountName { get; set; }
    }
}

