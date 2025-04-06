# SignalR Apps
- Adds real-time functionality to web apps
- Supports two-way communication between web clients and server (hub)
- Supports multiple transports
    - Web Sockets
    - Server-sent events
    - Long polling
- May be used within other ASP.NET Core projects

## Adding to existing projects
Add a *MessageHub.cs* class to the root of the project and listen for messages;
```C#
using Microsoft.AspNetCore.SignalR;

public class MessageHub : Hub {

    public async Task PostMessage(string message) {
        await Clients.All.SendAsync("ReceiveNewMessage", message);
    }
}
```

## Adding a client message sender / receiver
- Add a form
- Add SignalR Javascript
    - Run `npm install @microsoft/signalr`
    - Copy **signalr.min.js** from `node_modules\@microsoft\signalr\dist\browser\` to `wwwroot\js\`
