using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public byte[] PictureBinary { get; set; }
    }
}