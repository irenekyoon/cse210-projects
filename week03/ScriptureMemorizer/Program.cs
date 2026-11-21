using System;

class Program
{
    static void Main(string[] args)
    {
        string memorize = "";

        Reference reference2 = new Reference("1 Thessalonians", 5, 18, 19);
        Scripture scripture2 = new Scripture(reference2, "In every thing give thanks: Quench not the Spirit.");

        string ref2 = reference2.GetDisplayVerses();
        Console.WriteLine(ref2);
        string scrip2 = scripture2.GetDisplayText();
        Console.Write(scripture2.GetDisplayText());

        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
        
        while (memorize != "quit")
        {
            Console.ReadLine();
            Console.Clear();
            scripture2.HideRandomWords(3);

            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            // if (scripture2.IsCompletelyHidden())
            // {
            //     Console.WriteLine("Thank You");
            // }
        }
        Console.WriteLine("Thank you. The End");
    }
}
