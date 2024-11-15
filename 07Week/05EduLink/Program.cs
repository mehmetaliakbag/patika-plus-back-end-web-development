using DataLibrary;

public class Program
{
    // Main method to initiate the program
    public static void Start()
    {
        // Fetch the list of students and classes from data source
        List<Student> students = Data.Students();
        List<Class> classes = Data.Classes();

        // Group students by their ClassId and match with corresponding classes
        var result = classes.GroupJoin(
            students,
            c => c.ClassId,    // Key from the classes (ClassId)
            s => s.ClassId,    // Key from the students (ClassId)
            (group, studentGroup) => new  // Projection into a new object
            {
                CourseName = group.ClassName,  // Class name
                Students = studentGroup        // List of students in this class
            });

        // Iterate through each class and its students
        foreach (var group in result)
        {
            Console.WriteLine($"Course: {group.CourseName}");

            // List all students for the current class
            foreach (var student in group.Students)
            {
                Console.WriteLine($"  - {student.StudentName}");
            }

            Console.WriteLine();  // Print an empty line after each class
        }
    }

    // Main entry point of the application
    public static void Main(string[] args)
    {
        Start();  // Call the Start method to begin execution
    }
}
