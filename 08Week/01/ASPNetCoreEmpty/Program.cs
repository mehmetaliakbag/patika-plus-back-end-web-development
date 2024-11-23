var builder = WebApplication.CreateBuilder(args);

// Adding MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Enabling static files
app.UseStaticFiles();

// Configuring routing
app.UseRouting();

// Setting up default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

// **Controller**: A class that handles HTTP requests (e.g., GET, POST) from the user. It usually contains business logic and sends data to the view.
// **Action**: A specific method within a controller that performs a task, such as rendering a page or processing data. For example, an "Index" method might return the homepage.
// **Model**: A class that represents the data structure. It is used to transfer data between the controller and the view.
// **View**: Razor-based files responsible for rendering the user interface. They typically contain HTML, CSS, and Razor code.
// **Razor**: A template engine in .NET used to combine C# code with HTML on the server side.
// **RazorView**: A UI component rendered using Razor templates. For instance, data from a `cshtml` file is displayed through RazorView.
// **wwwroot**: The folder where all static files (CSS, JS, images, etc.) are located. These files are directly accessible by the browser.
// **builder.Build()**: Finalizes the middleware configuration required for the application and returns an object to run the application.
// **app.Run()**: Starts listening for HTTP requests and runs the application.

