using System;

class Program
{
    static void Main(string[] args)
    {
        string memorize = "";
        //Reference reference = new Reference("1 Thessalonians", 5, 19);
        //Scripture scripture = new Scripture(reference, "Quench not the Spirit");
        //string ref1 = reference.GetDisplayOneVerse();
        //Console.WriteLine(ref1);
        //string scrip1 = scripture.GetDisplayText();
        //Console.WriteLine(scrip1);

        Reference reference2 = new Reference("1 Thessalonians", 5, 18, 19);
        Scripture scripture2 = new Scripture(reference2, "In every thing give thanks: for this is the will of God in Christ Jesus concerning you. Quench not the Spirit.");

        string ref2 = reference2.GetDisplayVerses();
        Console.WriteLine(ref2);
        string scrip2 = scripture2.GetDisplayText();
        Console.WriteLine(scrip2);

        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

        while (memorize != "quit")
        {
            Console.ReadLine();
            Console.Clear();

            scripture2.GetDisplayText();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            if (scripture2.IsCompletelyHidden())
            {
                Console.WriteLine("Thank You");
            }
        }
        Console.WriteLine("Thank you. The End");
    }
}


