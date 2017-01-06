using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxImageDemo.Models
{
    public class Player
    {
        private static int i = 0;
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string PlaceofBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Image { get; set; }
        public List<string> stringList { get; set; }

        public Player()
        {
            PlayerId = i;
            i++;
            Name = "Player" + i;
            PlaceofBirth = "Place" + i;
            DateOfBirth = DateTime.Now;
            Image = new byte[] {1,2,3,4,5 };
            stringList = new List<string>();
        }
    }
}