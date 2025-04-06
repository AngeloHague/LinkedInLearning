using Microsoft.AspNetCore.Mvc;

namespace controller_api.Controllers;

[ApiController]
// Route attribute will accept the default route template of "WeatherForecast"
// or you can specify a custom route template like "api/[controller]"
// API Controller, unlike MVC, does not add support for Views and Razor Pages
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    // GET: /WeatherForecast
    // No additional route is specified, so this will respond to the default route
    // Adding "5day" to the route will make it respond to /WeatherForecast/5day
    [HttpGet("5day", Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
