using System;
public class Rose : Flower
{
    private int _thorns;
    private string _color;

    public Rose(string color, int thorns) : base(color)
    {
        _thorns = thorns;
        _color = color;
    }

    public new string GetColor()
    {
        return $"very {_color}";
    }

    public new string Describe()
    {
        //return $"This rose is {GetColor()} and has {_thorns} thorns";
        return $"This flower is {_color}. This rose has {_thorns} thorns";
    }


}
