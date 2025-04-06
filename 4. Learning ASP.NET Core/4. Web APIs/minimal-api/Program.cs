var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Same Weather Forecast data as with Controller-based API, implemented differently
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// Get request to /api/weatherforecast/5day
// Can capture route segments with curly braces; e.g. "/api/weatherforecast/5day/{location}", (string location) => { ... }
app.MapGet("/api/weatherforecast/5day/", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
// Can add other requests with app.MapPut, app.MapPost, etc.


// Adding another GET request
app.MapGet("/api/ideal-weather/{favourite_weather}", (string favourite_weather) => {
    return $"Your favourite weather is {favourite_weather}.";
});

app.Run();

// This record could be a class, but using a record is more concise and idiomatic in C# 9+
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
