using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class User
    {
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public User()
        {
            CreatedDate = DateTime.Now;
        }
    }
}