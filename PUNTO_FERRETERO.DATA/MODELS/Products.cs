using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.MODELS
{
    public class Product
    {
        [Key]
        public Guid productId { get; set; }
        public string productName { get; set; }
        public Guid productCategoryId { get; set; }
        public int itenCount { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public bool isDeleted { get; set; }
        public string description { get; set; }
        public Guid? discountId { get; set; }

    }
}

