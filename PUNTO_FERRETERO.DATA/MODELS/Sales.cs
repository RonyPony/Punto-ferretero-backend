using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.MODELS
{
    public class Sales
    {
        [Key]
        public Guid saleId { get; set; }
        public Guid productId { get; set; }
        public Guid discountId { get; set; }
        public Guid userId { get; set; }
        public decimal subTotal { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public bool isDeleted { get; set; }
    }
}


