using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxImageDemo.Models
{
    public class AjaxContext :DbContext
    {
        public AjaxContext() : base()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> Images { get; set; }

        public DbSet<Player> Players { get; set; }

        public System.Data.Entity.DbSet<AjaxImageDemo.Models.Contact> Contacts { get; set; }
    }
}