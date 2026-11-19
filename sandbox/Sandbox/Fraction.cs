using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Did you mean to enter something different? Your denominator is 0.");
        }
        _top = top;
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;

    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Your denominator is zero. That isn't allowed.");
        }

    }

    public string GetFractionString()
    {
        string fracString = $"{_top}/{_bottom}";
        return fracString;
    }

    public double GetDecimalValue()
    {
        double decValue = _top / (double)_bottom;
        return decValue;
    }
}