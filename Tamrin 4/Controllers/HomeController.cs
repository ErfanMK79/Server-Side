using Microsoft.AspNetCore.Mvc;
using projectZ.Models;
using System.Diagnostics;

namespace projectZ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Store(Products product02)
        {
            List<Products> products = new List<Products>();
            Products product01 = new Products();
            product01.Id = 1;
            product01.Name = "کنسول بازی PS4";
            product01.Specification = "hard 1TB";
            product01.Description = "";
            product01.Category = "کالای گیم";
            product01.Price = 6309;
            product01.Exist = true;
            products.Add(product01);
            Products product06 = new Products();
            product06.Id = 2;
            product06.Name = "هدست بازی ";
            product06.Specification = "";
            product06.Description = "";
            product06.Category = "کالای گیم";
            product06.Price = 2034;
            product06.Exist = true;
            products.Add(product06);
            Products product03 = new Products();
            product03.Id = 3;
            product03.Name = "دیسک بازی کالاف";
            product03.Specification = "";
            product03.Description = "";
            product03.Category = "بازی ها";
            product03.Price = 6120;
            product03.Exist = true;
            products.Add(product03);
            Products product04 = new Products();
            product04.Id = 4;
            product04.Name = "دیسک بازی ماشینی";
            product04.Specification = "";
            product04.Description = "";
            product04.Category = "بازی ها";
            product04.Price = 2120;
            product04.Exist = true;
            products.Add(product04);
            Products product05 = new Products();
            product05.Id = 5;
            product05.Name = "کابل برق کنسول";
            product05.Specification = "western blue";
            product05.Description = "";
            product05.Category = "لوازم جانبی";
            product05.Exist = false;
            products.Add(product05);
            var p = products.Where(x=>x.Exist).ToList();
            var sum= products.Sum(x=>x.Price);
            ViewBag.Sum = sum;
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}