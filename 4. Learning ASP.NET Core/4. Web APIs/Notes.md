# ASP.NET Core Web APIs
There are two different types of .NET WEB APIs;
- Controller-based web APIs
- Minimal web APIs

## Controller-based Web APIs
### Features
- Designed to work over HTTP
- Used to build RESTful APIs
- Serve data to all types of apps
- Build around controller classes (similar to MVC)
- Full-featured including model binding, model validation, JsonPatch, and more.

### Create with .NET CLI
Can be created using; 

```powershell
dotnet new webapi --use-controllers
```

### Adding controllers
Can be added using; 

```powershell
dotnet new apicontroller  --name [NAME] --output [FOLDER] --namespace [NAMESPACE] --actions
```


## Minimal Web APIs
- Designed to work over HTTP
- Used to build RESTful APIs
- Serve data to all types of apps
- Define endpoints with handlers in lambdas or methods
- Many, but not all of the features available in controller-based APIs.

### Create with .NET CLI
Can be created using; 

```powershell
dotnet new webapi
```

### Adding routes
Can be added using;

```C#
app.MapGet("/path/to/route/{param}", (string param) => {
    return $"Your input param is {param}.";
});
```

### Testing with Swagger (Versions below .NET 9.0)
Swagger has been deprecated as of .NET 9.0, and is not shipped with the template. As such, I created an APi with an earlier version to continue to learn these features.
```powershell
dotnet new webapi -f net8.0 -o minimal-api-dotnet-8
```

#### Checking the JSON
While running in development, the JSON can be found at; `/swagger/v1/swagger.json`

#### Viewing the UI
While running in development, the JSON can be found at; `/swagger/index.html`

