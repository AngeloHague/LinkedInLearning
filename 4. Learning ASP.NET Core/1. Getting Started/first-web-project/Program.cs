var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Adding services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();

// Adding scoped services
// builder.Services.AddScoped<IMyCustomService, MyCustomService>(); // example non-existent

var app = builder.Build();

// Adding dev middleware
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // dev friendly error page
}
else
{
    app.UseExceptionHandler("/Error"); // user friendly error page (not existent atm)
}

app.UseStaticFiles(); // shortcircuit the pipeline for static files rather than dynamic

// Adding custom middleware
app.Use(async(context, next) => {
    context.Response.Headers.Add("X-My-Custom-Header", "My Custom Header Value");
    await next.Invoke();
});

app.MapGet("/", () => "Hello World!");


app.MapGet("/about", () => "This page is all about our company.");

app.Run();
