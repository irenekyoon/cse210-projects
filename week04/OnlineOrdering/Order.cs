using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer = new Customer();

    private List<Product> _products = new List<Product>();
    private double _total = 0;

    public Order()
    {

    }
    // public void TotalCost()
    // {
    //     // double subtotal = ;  how do i call GetSubtotal()?

    //     Address address = new Address();
    //     string country = address.GetCountry();
    //     double shipping = 0.00;

    //     if (country == "USA")
    //     {
    //         shipping = 5.00;
    //         _total = subtotal + shipping;
    //     }

    //     else if (country == "other")
    //     {
    //         shipping = 35.00;
    //         _total = subtotal + shipping;
    //     }

    //     Console.WriteLine($"Subtotal: {subtotal}");
    //     Console.WriteLine($"Shipping fee: {shipping}");
    //     Console.WriteLine($"Total: {_total}");
    // }
    public void PackingLabel(List<Product> _products)
    {
        string pLabel = "";
        foreach (Product p in _products)
        {
            pLabel = ($"{p.GetName()} (Product ID: {p.GetId()})");
            Console.WriteLine(pLabel);
        }
    }

    public void ShippingLabel(string name, string address)
    {
        name = _customer.GetName();
        address = _customer.GetAddress();

    }
}




