using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Parts 1 & 2");
        Console.Write("What is your grade percentage? ");

        string percentage = Console.ReadLine();
        int percentAsNum = int.Parse(percentage);

        if (percentAsNum >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }

        else if (percentAsNum >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }

        else if (percentAsNum >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }

        else if (percentAsNum >= 60)
        {
            Console.WriteLine("Your grade is a D ");
        }

        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (percentAsNum >= 70)
        {
            Console.WriteLine("Congratulations! You passed this course! Well done!");
        }

        else
        {
            Console.WriteLine("You tried your best. Try again! Never give up!");
        }

        Console.WriteLine("");
        Console.WriteLine("Part 3");
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int percentNum = int.Parse(percent);
        string letter;
        if (percentNum >= 90)
        {
            letter = "A";
        }
        else if (percentNum >= 80)
        {
            letter = "B";
        }
        else if (percentNum >= 70)
        {
            letter = "C";
        }
        else if (percentNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}.");
    }
}