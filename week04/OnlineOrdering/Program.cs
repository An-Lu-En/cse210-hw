using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------
        // ORDER 1 (USA Customer)
        // ---------------------
        Address addr1 = new Address("123 Sunset Street", "Miami", "FL", "USA");
        Customer cust1 = new Customer("John Davis", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P1001", 850f, 1));
        order1.AddProduct(new Product("Mouse", "P2002", 25f, 2));

        // ---------------------
        // ORDER 2 (International Customer)
        // ---------------------
        Address addr2 = new Address("45 Kings Road", "London", "London", "UK");
        Customer cust2 = new Customer("Emily Rose", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "P3003", 80f, 1));
        order2.AddProduct(new Product("Microphone", "P4004", 120f, 1));
        order2.AddProduct(new Product("USB Cable", "P5005", 10f, 3));

        // ---------------------
        // DISPLAY RESULTS
        // ---------------------
        DisplayOrder(order1);
        Console.WriteLine("\n----------------------------------------\n");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order.GetTotalCost()}");
    }
}
