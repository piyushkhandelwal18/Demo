using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public IQueryable<Product> Products { get; set; }
    }
}