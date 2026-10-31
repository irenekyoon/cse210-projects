using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string userName;
        int userNumber;
        int sqNumber;

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        userName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        userNumber = PromptUserNumber();

        // Console.WriteLine($"user name: {userName}, user fav number: {userNumber}");

        static int SquareNumber(int first)
        {
            int userSquare = (first * first);
            return userSquare;
        }

        sqNumber = SquareNumber(userNumber);

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        }

        DisplayResult(userName, sqNumber);

    }
}