namespace BasicMVC.Models
{
    public class Order
    {
        // Unique identifier for the order
        public int Id { get; set; }

        // Name of the product in the order
        public string ProductName { get; set; }

        // Price of the product
        public decimal Price { get; set; }

        // Quantity of the product ordered
        public int Quantity { get; set; }
    }
}
