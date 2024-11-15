using DataLibrary;  // Importing DataLibrary for data operations.

public class Program
{
    // Main method to initiate the operations.
    public static void Start()
    {
        List<int> numbers = Data.Numbers();  // Fetch the list of numbers.

        PrintQuery(numbers, "List");

        GetEvenNumbers(numbers);  // Get and print even numbers.

        GetOddNumbers(numbers);   // Get and print odd numbers.
        
        GetNegativeNumbers(numbers);  // Get and print negative numbers.
        
        GetPositiveNumbers(numbers);  // Get and print positive numbers.
        
        GetNumbersBetween15And22(numbers);  // Get numbers between 15 and 22.

        List<int> squaredNumbers = CreateSquaredNumbersList(numbers);  // Create squared numbers list.
        
        PrintQuery(squaredNumbers, "Squared Numbers");

        Console.ReadKey();  // Wait for user input.
    }

    // Filter and print even numbers (excluding zero).
    private static void GetEvenNumbers(List<int> numbers)
    {
        var result = numbers.Where(number => number % 2 == 0 && number != 0);

        PrintQuery(result, "Even Numbers");
    }

    // Filter and print odd numbers.
    private static void GetOddNumbers(List<int> numbers)
    {
        var result = numbers.Where(number => number % 2 != 0);

        PrintQuery(result, "Odd Numbers");
    }

    // Filter and print negative numbers.
    private static void GetNegativeNumbers(List<int> numbers)
    {
        var result = numbers.Where(number => number < 0);

        PrintQuery(result, "Negative Numbers");
    }

    // Filter and print positive numbers.
    private static void GetPositiveNumbers(List<int> numbers)
    {
        var result = numbers.Where(number => number > 0);

        PrintQuery(result, "Positive Numbers");
    }

    // Filter and print numbers between 15 and 22.
    private static void GetNumbersBetween15And22(List<int> numbers)
    {
        var result = numbers.Where(number => 15 < number && number < 22);

        PrintQuery(result, "Numbers Between 15 And 22");
    }

    // Create a list with squared values of the numbers.
    private static List<int> CreateSquaredNumbersList(List<int> numbers)
    {
        var result = numbers.Select(number => number * number).ToList();

        return result;
    }

    // Print query results with a given title.
    private static void PrintQuery(IEnumerable<int> query, string title)
    {
        Console.WriteLine($"{title}\r\n");

        foreach (var number in query)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
    }

    // Entry point for the program.
    public static void Main(string[] args)
    {
        Start();  // Start the program.
    }
}