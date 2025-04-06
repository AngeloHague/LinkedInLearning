namespace code_challenge.Models;

public class BooksModel {
    public string[] BookTitles { get; set; }
    public string Favourite { get; set; }

    public BooksModel() {
        // retrieve data from DB or web service
        // hardcode for example
        BookTitles = [
            "Book A",
            "Book B",
            "Book C",
            "Book D",
            "Book E"
        ];
        Favourite = BookTitles[0];
    }

    public string getFavouriteBook() {
        return BookTitles[0];
    }
}