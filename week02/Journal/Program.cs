using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Please select one of the following choices:");
        int userInt = 0;
        while (userInt != 5)
        {

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            userInt = int.Parse(userChoice);

            if (userInt == 1)
            {
                Console.WriteLine(entry1._prompt);
                Console.Write("< ");
                entry1._entry = Console.ReadLine();
                Console.WriteLine("an entry is being added...");
                journal.AddEntry(entry1);
            }

            else if (userInt == 2)
            {
                journal.DisplayEntries();
            }

            else if (userInt == 3)
            {
                Console.Write("What is your filename? ");
                string loadEntries = Console.ReadLine();
                journal.LoadFromFile(loadEntries);
                Console.Write("What would you like to do? ");
            }

            else if (userInt == 4)
            {
                Console.Write("What is your filename? ");
                string saveEntries = Console.ReadLine();
                journal.SaveToFile(saveEntries);
                Console.Write("What would you like to do? ");
            }

            else
            {
                Console.WriteLine("Thank you.");
            }
        }
    }
}