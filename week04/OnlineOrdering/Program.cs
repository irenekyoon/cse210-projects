using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1502, One Ayala Tower, Ayala Ave", "Makati City", "Metro Manila", "Philippines");
        Customer customer1 = new Customer("Amanda dela Cruz", address1);
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Think Celestial T-Shirt", "S00125", 5.00, 5));
        products1.Add(new Product("Seoul Temple Print", "P00258", 7.00, 10));

        Address address2 = new Address("8265 4th Street", "Santa Rosa", "Callifornia", "USA");
        Customer customer2 = new Customer("James Smith", address2);
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Good Shepherd Painting", "P00326", 10.00, 1));
        products2.Add(new Product("Manila Temple Print", "P00452", 5.00, 2));

        Order order1 = new Order();
        Console.WriteLine();
        Console.WriteLine("Buyer:");
        order1.ShippingLabel(customer1.GetName(), customer1.GetAddress());
        Console.WriteLine("Items Purchased:");
        order1.PackingLabel(products1);
        // order.TotalCost(products1);

        Order order2 = new Order();
        Console.WriteLine();
        Console.WriteLine("Buyer:");
        order2.ShippingLabel(customer2.GetName(), customer2.GetAddress());
        Console.WriteLine("Items Purchased:");
        order2.PackingLabel(products2);
    }
}