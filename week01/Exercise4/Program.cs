using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;
        int total = 0;
        int lrgNum = -1;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            total = total + number;
            if (number > lrgNum)
                lrgNum = number;

        }
        Console.WriteLine($"The number of items in the list is: {numbers.Count}");
        Console.WriteLine($"The sum is: {total}");

        float average = total / (numbers.Count - 1);
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {lrgNum}");

        
    }
}