using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ImageContext : DbContext
    {
        public ImageContext():base()
        {

        }

        public DbSet<User> Users { get; set; }
    }
}