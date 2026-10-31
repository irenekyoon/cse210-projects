using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number? ");
        string magicString = Console.ReadLine();
        int mNum = int.Parse(magicString);

        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guessNum = int.Parse(guessString);

        if (guessNum > mNum)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNum < mNum)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        Console.WriteLine("");
        Console.WriteLine("Part 2: With a Loop");

        Console.Write("What is the magic number? ");
        string mString = Console.ReadLine();
        int mNumber = int.Parse(mString);

        Console.Write("What is your guess? ");
        string userString = Console.ReadLine();
        int userNumber = int.Parse(userString);

        while (mNumber != userNumber)
        {
            if (userNumber > mNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                userString = Console.ReadLine();
                userNumber = int.Parse(userString);
            }
            else if (userNumber < mNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                userString = Console.ReadLine();
                userNumber = int.Parse(userString);
            }
        }
        if (mNumber == userNumber)
        {
            Console.WriteLine("You guesssed it!");
        }

        Console.WriteLine("");
        Console.WriteLine("Part 3: Add Random Class");
        Random randomMagic = new Random();
        int magicNumber = randomMagic.Next(1, 101);

        Console.WriteLine("Guess a number between 1 and 100: ");
        string userGuess = Console.ReadLine();
        int userNum = int.Parse(userGuess);

        do
        {
            if (userNum > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userNum = int.Parse(userGuess);
            }
            else if (userNum < magicNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userNum = int.Parse(userGuess);
            }
        } while (userNum != magicNumber);

        if (userNum == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }


    }
}