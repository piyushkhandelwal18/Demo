using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxImageDemo.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase attachment { get; set; }
    }
}