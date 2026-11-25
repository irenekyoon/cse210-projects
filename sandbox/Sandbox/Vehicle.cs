using System;

public class Vehicle
{
    private string _name;
    protected int _topSpeed;

    public Vehicle(string name, int topSpeed)
    {
        _name = name;
        _topSpeed = topSpeed;
    }

    public virtual string Describe()
    {
        return $"{_name}, top speed {_topSpeed} km/h";
    }
}