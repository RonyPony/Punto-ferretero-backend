using Microsoft.EntityFrameworkCore;
using PUNTO_FERRETERO.DATA.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.CONTEXT
{
    public partial class PUNTO_FERRETEROContext : DbContext
    {
        public PUNTO_FERRETEROContext(DbContextOptions<PUNTO_FERRETEROContext> options)
           : base(options)
        {
           
        }

        public DbSet<User>users { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
    }
}
