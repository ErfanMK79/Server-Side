using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje_1_.Models;

namespace Proje_1_.Controllers;

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

    public IActionResult aboutus()
    {
        return View();
    }

    public IActionResult contactus()
    {
        return View();
    }

    public IActionResult shop()
    {
        return View();
    }

    public IActionResult login()
    {
        return View();
    }

    public IActionResult product()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
