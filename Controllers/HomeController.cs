using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ELocal.Models;

namespace ELocal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var events = new List<Event>
    {
        new Event { Name = "PHP Conference", Description = "A great PHP conference", Date = new DateTime(2014, 1, 17) },
        // Añade más eventos aquí
    };

        return View(events);
    }

    public IActionResult Schedule()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Account()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}
