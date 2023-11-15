using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new List<Person>()
        {
            new Person()
            {
                Name = "Mateusz",
                LastName = "Miłkowski",
            },

            new Person()
            {
                Name = "Jan",
                LastName = "Kowalski",
            },
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About() 
    {
        var model = new About() 
        {
            Title = "Strona about",
            Description = "Strona na której testuje",
            Tags = new List<string>() {"Test", "Strona"}

        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
