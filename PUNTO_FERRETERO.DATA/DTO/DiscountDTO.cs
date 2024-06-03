using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.DTO
{
    public class DiscountDTO
    {
        public Guid discountId { get; set; }
        public string discountName { get; set; }
        public decimal discountPorcentage { get; set; }
        public decimal discountTotal { get; set; }
        public string discountCode { get; set; }
    }
}

