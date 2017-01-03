using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxImageDemo.Models
{
    public class AppContext :DbContext
    {
        public AppContext() : base()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> Images { get; set; }
    }
}