var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var books = new[]
{
    new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams"),
    new Book("The Great Gatsby", "F. Scott Fitzgerald"),
    new Book("1984", "George Orwell"),
    new Book("To Kill a Mockingbird", "Harper Lee"),
    new Book("Pride and Prejudice", "Jane Austen")
};

app.MapGet("/api/books", () =>
{
    return books;
})
.WithName("GetAllBooks")
.WithOpenApi();

app.MapGet("/api/books/search/term/{term}", (string term) =>
{
    List<Book> results = [];
    foreach (Book book in books)
    {
        if (book.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
            book.Author.Contains(term, StringComparison.OrdinalIgnoreCase))
        {
            results.Add(book);
        }
    }
    return results;
})
.WithName("SearchBooks")
.WithOpenApi();

app.MapGet("/api/books/search/title/{term}", (string term) =>
{
    List<Book> results = [];
    foreach (Book book in books)
    {
        if (book.Title.Contains(term, StringComparison.OrdinalIgnoreCase))
        {
            results.Add(book);
        }
    }
    return results;
})
.WithName("SearchBookTitles")
.WithOpenApi();

app.MapGet("/api/books/search/author/{term}", (string term) =>
{
    List<Book> results = [];
    foreach (Book book in books)
    {
        if (book.Author.Contains(term, StringComparison.OrdinalIgnoreCase))
        {
            results.Add(book);
        }
    }
    return results;
})
.WithName("SearchBookAuthors")
.WithOpenApi();

app.Run();

record Book(string Title, string Author) { }
