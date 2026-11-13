using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Thessalonians", 5, 19);
        Scripture scripture = new Scripture(reference, "Quench not the Spirit");
        scripture.HideRandomWords(2);
        reference.GetDisplayOneVerse();

        // Reference reference2 = new Reference("1 Thessalonians", 5, 18, 19);
        // reference2.GetDisplayVerses();

        
        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

        Console.ReadLine();
        Console.Clear();
        

        

    }
}