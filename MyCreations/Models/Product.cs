using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCreations.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string OwnerName { get; set; }
    }
}
