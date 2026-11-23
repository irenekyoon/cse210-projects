using System;
public class Flower
{
    private string _color;

    public Flower(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public string Describe()
    {
        return $"This flower is {_color}";
    }
    // public virtual string Describe()
    // {
    //     return $"This flower is {_color}";
    // }

}