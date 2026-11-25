using System;

public class Truck : Vehicle
{
    private int _cargoCapacity;

    public Truck(string name, int speed, int capacity) : base(name, speed)
    {
        _cargoCapacity = capacity;
    }

    public override string Describe()
    {
        return $"Truck Override plus base dot: {base.Describe()}, carries {_cargoCapacity} kg";
    }
}
