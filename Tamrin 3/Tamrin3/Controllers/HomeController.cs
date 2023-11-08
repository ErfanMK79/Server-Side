using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tamrin3.Models;

namespace Tamrin3.Controllers;

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

    public IActionResult Store(Products product02)
    {
        List<Products> products = new List<Products>();
        Products product01 = new Products();
        product01.Id = 1;
        product01.Name = "کنسول بازی PS3";
        product01.Specification = "مدل C50";
        product01.Description = "";
        product01.Category = "کنسول بازی";
        product01.Price = 1490;
        product01.Inventory = true;
        products.Add(product01);
        Products product06 = new Products();
        product06.Id = 2;
        product06.Name = "کنسول بازی PS4";
        product06.Specification = "مدل A5040";
        product06.Description = "";
        product06.Category = " کنسول بازی";
        product06.Price = 1280;
        product06.Inventory = true;
        products.Add(product06);
        Products product03 = new Products();
        product03.Id = 3;
        product03.Name = " سامسونگ S23 ultra";
        product03.Specification = "512 گیگ";
        product03.Description = "";
        product03.Category = " موبایل";
        product03.Price = 2950;
        product03.Inventory = true;
        products.Add(product03);
        Products product04 = new Products();
        product04.Id = 4;
        product04.Name = "مانیتور asus 7050";
        product04.Specification = "4K";
        product04.Description = "";
        product04.Category = "مانیتور ها ";
        product04.Price = 1370;
        product04.Inventory = true;
        products.Add(product04);
        Products product05 = new Products();
        product05.Id = 5;
        product05.Name = "دسته بازی  Ps5";
        product05.Specification = "PS5";
        product05.Description = "";
        product05.Category = "کنسول بازی ";
        product05.Price = 4000;
        product05.Inventory = false;
        products.Add(product05);
        var p = products.Where(x => x.Inventory).ToList();
        var sum = products.Sum(x => x.Price);
        ViewBag.Sum = sum;
        return View(p);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
