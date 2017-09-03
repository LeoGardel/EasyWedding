using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWedding.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string PicturePath { get; set; }
    }
}