using Grpc.Core;
using grpc_server;

namespace grpc_server.Services;

public class WebDevService : WebDev.WebDevBase
{
    private readonly ILogger<WebDevService> _logger;
    public WebDevService(ILogger<WebDevService> logger)
    {
        _logger = logger;
    }

    public override Task<ProjectConfirmation> CreateProject(Project project, ServerCallContext context)
    {
        return Task.FromResult(new ProjectConfirmation
        {
            Msg = $"Project '{project.Name}' created successfully!"
        });
    }
}
