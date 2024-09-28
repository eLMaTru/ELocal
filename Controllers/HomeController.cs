using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ELocal.Models;
using ELocal.Services;
using Microsoft.EntityFrameworkCore;

namespace ELocal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEventService _eventService;

    public HomeController(ILogger<HomeController> logger, IEventService eventService)
    {
        _logger = logger;
        _eventService = eventService;
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
    var events = new List<Event>
    {
        new Event {
            Name = "UX Design Trend Party 2019", 
            Description = "In order to save time you have to break down the content strategy...",
            Date = new DateTime(2019, 1, 17, 9, 30, 0),  // Includes both date and time
            Location = "Waterfront Hotel, London",
            ImageUrl = "https://social.webestica.com/assets/images/post/3by2/01.jpg"
        },
        new Event {
            Name = "Rokolo DJ Dancing 2019",
            Description = "In order to save time you have to break down the content strategy...",
            Date = new DateTime(2019, 1, 17, 9, 30, 0),  // Includes both date and time
            Location = "Waterfront Hotel, London",
            ImageUrl = "https://social.webestica.com/assets/images/events/01.jpg"
        },
          new Event {
            Name = "UX Design Trend Party 2019", 
            Description = "In order to save time you have to break down the content strategy...",
            Date = new DateTime(2019, 1, 17, 9, 30, 0),  // Includes both date and time
            Location = "Waterfront Hotel, London",
            ImageUrl = "https://social.webestica.com/assets/images/events/02.jpg"
        },
        new Event {
            Name = "Rokolo DJ Dancing 2019",
            Description = "In order to save time you have to break down the content strategy...",
            Date = new DateTime(2019, 1, 17, 9, 30, 0),  // Includes both date and time
            Location = "Waterfront Hotel, London",
            ImageUrl = "https://social.webestica.com/assets/images/events/06.jpg"
        }
    };

    return View(events);
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
  
    public IActionResult Places()
    {
        var events = _eventService.GetUpcomingEvents();
        return View(events);
    }

    public IActionResult Details(int id)
    {
        var eventDetails = _eventService.GetEventById(id);
        if (eventDetails == null)
        {
            return NotFound();
        }
        return View(eventDetails);
    }
}
