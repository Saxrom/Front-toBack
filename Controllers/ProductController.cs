using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTask_FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeTask_FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private string[] Img = {
            "https://wallpapercave.com/wp/wp5609839.png",
            "https://wallpaperaccess.com/full/2161382.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkIwlp0SWjJxXpKPGh6cmTV0BSXUJOlzc59g&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJOcMDA-NzptpzvvOJDruwwAd2pA-zeJtyEw&usqp=CAU"
        };

        private List<ProductItem> _items;

        public ProductController()
        {
            _items = new List<ProductItem>();
            _items.Add(new ProductItem { Id = 1, Name = "Earth", ImageUrl = Img[0] });
            _items.Add(new ProductItem { Id = 2, Name = "Product2", ImageUrl = Img[1] });
            _items.Add(new ProductItem { Id = 1, Name = "Product3", ImageUrl = Img[2] });
            _items.Add(new ProductItem { Id = 1, Name = "Product4", ImageUrl = Img[3] });
        }

        

        public IActionResult Index()
        {
            return View(_items);
        }
    }
}
