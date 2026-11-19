using System;

public class Product
{
    private string _name = "";
    private string _prodId = "";
    private double _price = 0.00;
    private int _quantity = 0;

    List<Product> _products = new List<Product>();

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _prodId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _prodId;
    }

    public List<Product> GetList()
    {

        Console.WriteLine(_products);
        return _products;

    }

    public double GetSubtotal()
    {
        double subtotal = 0.00;
        foreach (Product p in _products)
        {
            double itemCost = _price * _quantity;
            subtotal = subtotal + itemCost;
            Console.WriteLine(subtotal);
        }
        return subtotal;
    }



}