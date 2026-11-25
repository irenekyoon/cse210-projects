using System;

public class Bicycle : Vehicle
{
    public Bicycle(string name, int speed) : base(name, speed)
    {

    }

    public override string Describe()
    {
        return "Bicycle Override: Trail Bike(pedal powered)";
    }

    public string ParentVersion()
    {
        return $"Bicycle ParentVersion uses base dot: {base.Describe()}";
    }

}