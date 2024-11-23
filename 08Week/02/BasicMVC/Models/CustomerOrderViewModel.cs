namespace BasicMVC.Models
{
    public class CustomerOrderViewModel
    {
        // Customer details
        public Customer Customer { get; set; }

        // List of customer orders
        public List<Order> Orders { get; set; }
    }
}
