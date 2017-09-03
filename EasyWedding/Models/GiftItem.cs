using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWedding.Models
{
    public class GiftItem
    {
        public int Id { get; set; }
        public int SelectedQuantity { get; set; }
        public decimal SelectedPrice { get; set; }
        public ShopItem Item { get; set; }
        public Gift Gift { get; set; }
    }
}