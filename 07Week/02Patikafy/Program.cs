using DataLibrary;
using System.Security.Cryptography;

public class Program
{
    // Main method to initiate the program
    public static void Start()
    {
        List<Singer> singers = Data.Singers();  // Fetch the list of singers

        GetSingersStarstWithS(singers);  // Display singers whose first name starts with 'S'

        GetSingersWithOver10MillionAlbumSales(singers);  // Display singers with over 10 million album sales

        GetPre2000PopSingersGroupedByDebutYear(singers);  // Display pop singers before 2000, grouped by debut year

        GetBestSellingSingerByAlbumSales(singers);  // Display the best-selling singer by album sales

        GetNewestAndOldestDebutSingers(singers);  // Display the newest and oldest debuting singers

        Console.ReadKey();  // Wait for user input before closing
    }

    // Display singers whose first name starts with 'S'
    private static void GetSingersStarstWithS(List<Singer> singers)
    {
        var result = singers.Where(singer => singer.FirstName.StartsWith('S'));  // Filter singers by first name

        Console.WriteLine("Singers Starts With S\r\n");

        // Print header with column names
        Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", "FirstName", "LastName", "Genre", "Release Year", "Album Sales(M)");

        // Print separator line for clarity
        Console.WriteLine(new string('-', 90));

        // Loop through each singer and display their data
        foreach (var singer in result)
        {
            // Print each singer's information in aligned columns
            Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", singer.FirstName, singer.LastName, singer.Genre, singer.ReleaseYear, singer.AlbumSalesMillion);
        }

        Console.WriteLine();
    }

    // Display singers with more than 10 million album sales
    private static void GetSingersWithOver10MillionAlbumSales(List<Singer> singers)
    {
        var result = singers.Where(singer => singer.AlbumSalesMillion > 10);  // Filter by album sales

        Console.WriteLine("Singers With Over 10 Million Sales\r\n");

        // Print header with column names
        Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", "FirstName", "LastName", "Genre", "Release Year", "Album Sales(M)");

        // Print separator line for clarity
        Console.WriteLine(new string('-', 90));

        // Loop through each singer and display their data
        foreach (var singer in result)
        {
            // Print each singer's information in aligned columns
            Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", singer.FirstName, singer.LastName, singer.Genre, singer.ReleaseYear, singer.AlbumSalesMillion);
        }

        Console.WriteLine();
    }

    // Display pop singers who debuted before 2000, grouped by debut year
    private static void GetPre2000PopSingersGroupedByDebutYear(List<Singer> singers)
    {
        var result = singers.Where(singer => singer.ReleaseYear < 2000 && singer.Genre.Contains("Pop"))
                            .GroupBy(singer => singer.ReleaseYear)  // Group by debut year
                            .OrderBy(singer => singer.Key);  // Sort by year

        Console.WriteLine("Pre 2000 Pop Singers Grouped By Debut Year");

        // Loop through each group and display data
        foreach (var group in result)
        {
            // Print the year heading, aligned
            Console.WriteLine($"\r\nYear: {group.Key}\r\n");

            // Print header with column names
            Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", "FirstName", "LastName", "Genre", "Release Year", "Album Sales(M)");
            Console.WriteLine(new string('-', 90)); // Line separator for clarity
                                                    // Print the details of each singer in the group with alignment
            foreach (var singer in group)
            {
                // Print each singer's information in aligned columns
                Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}",
                    singer.FirstName,
                    singer.LastName,
                    singer.Genre,
                    singer.ReleaseYear,
                    singer.AlbumSalesMillion);
            }
        }

        Console.WriteLine();
    }

    // Display the best-selling singer(s) based on album sales
    private static void GetBestSellingSingerByAlbumSales(List<Singer> singers)
    {
        var maxSales = singers.Max(singer => singer.AlbumSalesMillion);  // Find the maximum album sales

        var bestSellingSinger = singers.Where(singer => singer.AlbumSalesMillion == maxSales);  // Get the best-selling singer(s)

        Console.WriteLine("Best Selling Singer By Album Sales\r\n");

        // Print header with column names
        Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", "FirstName", "LastName", "Genre", "Release Year", "Album Sales(M)");

        // Print separator line for clarity
        Console.WriteLine(new string('-', 90));

        // Loop through each singer and display their data
        foreach (var singer in bestSellingSinger)
        {
            // Print each singer's information in aligned columns
            Console.WriteLine("{0,-15} {1,-15} {2,-25} {3,-15} {4,10}", singer.FirstName, singer.LastName, singer.Genre, singer.ReleaseYear, singer.AlbumSalesMillion);
        }
        Console.WriteLine();
    }

    // Display the newest and oldest debuting singers
    private static void GetNewestAndOldestDebutSingers(List<Singer> singers)
    {
        var newestSinger = singers.Max(singer => singer.ReleaseYear);  // Find the most recent debut year
        var oldestSinger = singers.Min(singer => singer.ReleaseYear);  // Find the oldest debut year

        var result = singers.Where(singer => singer.ReleaseYear == newestSinger || singer.ReleaseYear == oldestSinger);  // Filter singers by debut year

        Console.WriteLine("Newest And Oldest Debut Singers\r\n");

        // Print header with column names
        Console.WriteLine("{0,-15} {1,-15} {2,-50} {3,-15} {4,10}", "FirstName", "LastName", "Genre", "Release Year", "Album Sales(M)");

        // Print separator line for clarity
        Console.WriteLine(new string('-', 115));

        // Loop through each singer and display their data
        foreach (var singer in result)
        {
            // Print each singer's information in aligned columns
            Console.WriteLine("{0,-15} {1,-15} {2,-50} {3,-15} {4,10}", singer.FirstName, singer.LastName, singer.Genre, singer.ReleaseYear, singer.AlbumSalesMillion);
        }
    }

    // Main entry point of the application
    public static void Main(string[] args)
    {
        Start();  // Call Start method to run the program
    }
}
