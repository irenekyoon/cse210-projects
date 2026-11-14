using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        // // Fraction fraction = new Fraction();
        // // Fraction fraction2 = new Fraction(5);
        // // Fraction fraction3 = new Fraction(3, 5);
        // Fraction wholeNum = new Fraction();
        // Console.WriteLine(wholeNum.GetFractionString());
        // Console.WriteLine(wholeNum.GetDecimalValue());

        // Fraction wholeNum2 = new Fraction(5);
        // Console.WriteLine(wholeNum2.GetFractionString());
        // Console.WriteLine(wholeNum2.GetDecimalValue());

        // Fraction wholeNum3 = new Fraction(1, 3);
        // Console.WriteLine(wholeNum3.GetFractionString());
        // Console.WriteLine(wholeNum3.GetDecimalValue());

        Fraction fraction = new Fraction();
        fraction.SetTop(5);
        Console.WriteLine(fraction.GetTop());

    }
}