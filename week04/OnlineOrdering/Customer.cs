using System;

public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer()
    {

    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        Console.WriteLine(_name);
        return _name;
    }
   
    public string GetLocation()
    {
        string location = _address.GetCountry();
        return location;
    }

    public string GetAddress()
    {
        string address = _address.GetAddress();
        Console.WriteLine(address);
        return address;

    }


}