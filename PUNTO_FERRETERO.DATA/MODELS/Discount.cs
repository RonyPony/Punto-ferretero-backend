using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.MODELS
{
    public class Discount
    {
        [Key]
        public Guid discountId { get; set; }
        public string discountName { get; set; }
        public decimal discountPorcentage { get; set; }
        public decimal discountTotal { get; set; }
        public string discountCode { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
