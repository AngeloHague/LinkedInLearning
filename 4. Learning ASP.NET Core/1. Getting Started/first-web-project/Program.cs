var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();



var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/about", () => "This page is all about our company.");

app.Run();
