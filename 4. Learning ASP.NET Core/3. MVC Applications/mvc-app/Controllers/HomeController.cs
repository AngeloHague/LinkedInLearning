using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers;

// By convention, includes "Controller" in the class name and extends the Controller base
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // These are actions that respond to HTTP requests
    // This will handle /index for instance
    public IActionResult Index()
    {
        // Handle any business logic here
        // Then return a view; this will look for index.cshtml in the Home folder first, then the Shared folder
        return View();

        // This can be overloaded to return a different view if needed, e.g.
        // return View("AnotherView");

        // Or overload the View to return a different model, see the Error action below
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        // Overloaded to return a different view with a model
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
