using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("Blk 6 lot 9 Nut Street", "Nowhere.", "CA", "Philippines");
        Address address2 = new Address("Blk 9 lot 6 Lana Street", "MucTown", "NY", "USA");

        // Create customers
        Customer customer1 = new Customer("Sheena Ignacio", address1);
        Customer customer2 = new Customer("Kariza Balacanao", address2);

        // Create products
        Product product1 = new Product("Product 1", "P001", 10.5m, 2);
        Product product2 = new Product("Product 2", "P002", 15m, 3);
        Product product3 = new Product("Product 3", "P003", 8m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results for order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        // Display results for order 2
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
