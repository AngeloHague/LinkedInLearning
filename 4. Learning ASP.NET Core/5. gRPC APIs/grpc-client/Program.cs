// Console.WriteLine("Hello, World!");
using Grpc.Net.Client;
using grpc_client;

// var channel = GrpcChannel.ForAddress("http://localhost:5145");

// var webDevClient = new WebDev.WebDevClient(channel);

// var webDevReply = webDevClient.CreateProject( new Project { Name = "MyProject", Id = 1 });

// Console.WriteLine($"{webDevReply}");

// Code Challenge
var channel = GrpcChannel.ForAddress("http://localhost:5201");

var booksClient = new Books.BooksClient(channel);

var reply = booksClient.GetAuthor( new GetBookAuthorRequest { Title = "Test"});
Console.WriteLine($"{reply}");

reply = booksClient.GetAuthor( new GetBookAuthorRequest { Title = "1984"});
Console.WriteLine($"{reply}");