using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxImageDemo.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase attachment { get; set; }
        [NotMapped]
        List<SelectListItem> SelectList { get; set; }

        public Contact()
        {
            SelectList = new List<SelectListItem>();
        }
    }
}