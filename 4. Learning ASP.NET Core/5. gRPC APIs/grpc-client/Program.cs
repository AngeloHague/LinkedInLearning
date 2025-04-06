
using Grpc.Net.Client;
using grpc_client;

var channel = GrpcChannel.ForAddress("http://localhost:5145");

var webDevClient = new WebDev.WebDevClient(channel);

var webDevReply = webDevClient.CreateProject( new Project { Name = "MyProject", Id = 1 });

Console.WriteLine($"{webDevReply}");