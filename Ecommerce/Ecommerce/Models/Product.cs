using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Ecommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public List<SelectListItem> CategoryList { get; set; }
    }
}