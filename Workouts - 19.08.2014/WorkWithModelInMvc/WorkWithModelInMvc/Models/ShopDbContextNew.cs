using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkWithModelInMvc.Models
{
    public class ShopDbContextNew : DbContext
    {
        public ShopDbContextNew() : base("ShopDbConnectionString")
        {

        }

        public DbSet<Product> Products { set; get; }
    }
}