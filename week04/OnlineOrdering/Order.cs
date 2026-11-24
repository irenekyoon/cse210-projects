using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer = new Customer();

    private List<Product> _products = new List<Product>();
    //private Product _product = new Product();
   
    private double _total = 0;

    public Order()
    {

    }
    public void TotalCost(List<Product> _products, string country)
    {
        string shippingCountry = country;
        string address = _customer.GetAddress();
        
        double shipping = 0.00;
        double subtotal = 0.00;
        foreach (Product p in _products)
        {
            double pCost = p.CalculateCost();
            subtotal = subtotal + pCost;
        }
       
        if (shippingCountry == "USA")
        {
            shipping = 5.00;
            _total = subtotal + shipping;
        }

        else if (shippingCountry == "other")
        {
            shipping = 35.00;
            _total = subtotal + shipping;
        }

        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Shipping fee: ${shipping}");
        Console.WriteLine($"Total: ${_total}");
    }
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




