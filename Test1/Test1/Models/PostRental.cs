using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class PostRental
    {
        public string Description { get; set; }
        public int NoOfRooms { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
    }
}