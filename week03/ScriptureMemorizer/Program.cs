// To exceed expectations, I added a File class so I could upload scripture text from a text file.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference2 = new Reference("1 Thessalonians", 5, 18, 19);
        // Scripture scripture2 = new Scripture(reference2, "In every thing give thanks: Quench not the Spirit.");
        File file = new File("scripture.txt");
        Scripture scripture2 = new Scripture(reference2, file);
        string ref2 = reference2.GetDisplayVerses();
        Console.Write(ref2);
        string scrip2 = scripture2.GetDisplayText();
        Console.WriteLine(scrip2);

        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

        do
        {
            string response = Console.ReadLine();

            if (response != "quit")
            {
                Console.Clear();
                scripture2.HideRandomWords(3);

                Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            }
            else
            {
                Console.WriteLine("Thank you. The End");
            }
        } while (scripture2.IsCompletelyHidden() == false);
    }
}
