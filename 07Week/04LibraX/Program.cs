using DataLibrary;

public class Program
{
    // Entry point of the program
    public static void Start()
    {
        // Retrieve list of authors from the data source
        List<Author> authors = Data.Authors();

        // Retrieve list of books from the data source
        List<Book> books = Data.Books();

        // Call the method to join authors and books and display them
        GetBookTitleAndAuthorName(authors, books);

        Console.ReadKey();
    }

    // Method to join authors and books based on AuthorId and display book titles with author names
    private static void GetBookTitleAndAuthorName(List<Author> authors, List<Book> books)
    {
        // Join authors and books by matching AuthorId from both lists
        var result = authors.Join(books,  // Perform join
                     author => author.AuthorId,  // Key from authors list (AuthorId)
                     book => book.AuthorId,  // Key from books list (AuthorId)
                     (author, book) => new   // Select relevant data (BookTitle and AuthorName)
                     {
                         BookTitle = book.Title,  // Book title
                         AuthorName = author.Name  // Author name
                     });

        // Print header with column names
        Console.WriteLine("{0,-20} {1,-40}", "Author", "Book");

        // Print a separator line for visual clarity
        Console.WriteLine(new string('-', 60));

        // Iterate through the result and print the author and book details
        foreach (var element in result)
        {
            // Display the author and book title in aligned columns
            Console.WriteLine("{0,-20} {1,-40}", element.AuthorName, element.BookTitle);
        }
    }

    // Main method to start the program execution
    public static void Main(string[] args)
    {
        Start();  // Call the Start method to begin execution
    }
}
