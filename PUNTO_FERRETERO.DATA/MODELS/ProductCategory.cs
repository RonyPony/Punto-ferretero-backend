﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.MODELS
{
    public class ProductCategory
    {
        public Guid productcategoryId { get; set; }
        public string productcategoryName { get; set; }
        public string productcategoryDescription { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
