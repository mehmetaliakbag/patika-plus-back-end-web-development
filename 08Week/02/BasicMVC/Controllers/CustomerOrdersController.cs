using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // Displays customer details and their orders
        public IActionResult Index()
        {
            // Example customer data
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // Example order data
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 999.99m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 19.99m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Monitor", Price = 249.50m, Quantity = 2 },
            new Order { Id = 4, ProductName = "Keyboard", Price = 99.95m, Quantity = 5 },
            new Order { Id = 5, ProductName = "Smartphone", Price = 799.49m, Quantity = 1 },
            new Order { Id = 6, ProductName = "Headphones", Price = 149.99m, Quantity = 3 }
        };

            // Combine data into the ViewModel
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // Pass the ViewModel to the view
            return View(viewModel);
        }

    }
}