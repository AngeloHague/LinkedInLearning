using Grpc.Core;
using code_challenge;

namespace code_challenge.Services;

public class BooksService : Books.BooksBase
{

    record Book(string Title, string Author) { }
    Book[] books = [
        new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams"),
        new Book("The Great Gatsby", "F. Scott Fitzgerald"),
        new Book("1984", "George Orwell"),
        new Book("To Kill a Mockingbird", "Harper Lee"),
        new Book("Pride and Prejudice", "Jane Austen")
    ];
    public override Task<GetBookAuthorResponse> GetAuthor(GetBookAuthorRequest request, ServerCallContext context)
    {

        foreach (Book book in books)
        {
            if (book.Title == request.Title)
            {
                return Task.FromResult(new GetBookAuthorResponse
                {
                    Author = book.Author
                });
            }
        }
                return Task.FromResult(new GetBookAuthorResponse
                {
                    Author = "Unknown"
                });
    }
}
