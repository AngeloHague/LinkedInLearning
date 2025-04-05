var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Adding services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();

// Adding scoped services
// builder.Services.AddScoped<IMyCustomService, MyCustomService>(); // example non-existent

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/about", () => "This page is all about our company.");

app.Run();
