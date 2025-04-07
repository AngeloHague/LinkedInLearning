# Blazor Apps
- Allows you to build full-stack web apps entirely with .NET
- Uses Razor components, using the Razor Syntas as used before
- Multiple render mode
    - Static server (renders HTML on server, no interactivity)
    - Interactive server (renders HTML on server, but also allows for interactivity using SignalR)
    - Interactive WebAssembly (all interactivity is handled on the client)
    - Interactive auto

## Other options
- Blazor WebAssembly; runs entirely in the browser
- Blazor Hybrid; supports building native client apps

## Creating a Blazor App
Using CLI;
```powershell
dotnet new blazor --interactivity <choice>
```
Where choice is;
    - None; static server rendering
    - Server; runs of server (default option. sends client interactions using SignalR)
    - WebAssembly; runs in browser (creates a server and client project)
    - Auto' uses server while downloading WebAssembly (creates a server and client project)