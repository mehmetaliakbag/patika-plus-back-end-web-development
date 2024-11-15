using DataLibrary;
using System.Xml.Linq;

public class Program
{
    // Main entry point of the program
    private static void Start()
    {
        // Fetch the list of TV series from data source
        List<TVSeries> series = Data.TvSeries();

        // Filter and display comedy series
        GetComedySeries(series);

        Console.ReadKey();  // Wait for user input before closing
    }

    // Method to filter and display comedy series with their names, genres, and directors
    private static void GetComedySeries(List<TVSeries> series)
    {
        // Filter series where genre contains "Komedi" and select relevant properties
        var result = series.Where(series => series.Genre.Contains("Komedi"))
                           .Select(series => new
                           {
                               ComedySeriesName = series.Name,  // Extract series name
                               ComedySeriesGenre = series.Genre,  // Extract genre
                               ComedySeriesDirector = series.Director  // Extract director
                           });
        // Print header with column names
        Console.WriteLine("{0,-20} {1,-15} {2,-25}", "Series Name", "Genre", "Director");

        // Print a separator line for visual clarity
        Console.WriteLine(new string('-', 60));

        // Loop through each comedy series and print the details in formatted columns
        foreach (var element in result)
        {
            // Print series name, genre, and director with aligned columns
            Console.WriteLine($"{element.ComedySeriesName,-20} {element.ComedySeriesGenre,-15} {element.ComedySeriesDirector,-25}");
        }
    }

    // Main method to start the program execution
    public static void Main(string[] args)
    {
        Start();  // Call Start method to begin execution
    }
}
