using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxImageDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        public Product()
        {
            ProductImages = new List<ProductImage>();
        }
}
}