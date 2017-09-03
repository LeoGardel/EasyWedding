using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWedding.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<GiftItem> Gifts { get; set; }
    }
}