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

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public List<Product> GetList()
    {
        Console.WriteLine(_products);
        return _products;
    }

    public double CalculateCost()
    {
        double itemCost = 0.00;
        itemCost = _price * _quantity;
        return itemCost;
    }
}