using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWedding.Models;

namespace EasyWedding.Controllers
{
    public class ShopItemController : Controller
    {
        // GET: Store
        public ActionResult Index(int? pageIndex, string sortBy, string filteredCategory)
        {
            var shopItems = GetAllShopItems();
            return View(shopItems);
        }

        [Route("ShopItem/Details/{id}")]
        public ActionResult Show(int id)
        {
            ShopItem shopItem = GetAllShopItems().SingleOrDefault(item => item.Id == id);

            if (shopItem == null)
                return HttpNotFound();

            return View(shopItem);
        }
        
        private IEnumerable<ShopItem> GetAllShopItems()
        {
            return new List<ShopItem>()
            {
                new ShopItem(){ Id = 1, Name = "Item 1" },
                new ShopItem(){ Id = 2, Name = "Item 2" }
            };
        }
    }
}