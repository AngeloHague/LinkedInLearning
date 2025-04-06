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
```dotnet new webapi --use-controllers```
### Adding controllers
Can be added using; 
```dotnet new apicontroller  --name [NAME] --output [FOLDER] --namespace [NAMESPACE] --actions```


## Minimal Web APIs
- Designed to work over HTTP
- Used to build RESTful APIs
- Serve data to all types of apps
- Define endpoints with handlers in lambdas or methods
- Many, but not all of the features available in controller-based APIs.