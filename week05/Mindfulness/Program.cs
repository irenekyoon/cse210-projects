using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity act1 = new Activity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // act1.DisplayStartingMessage();
        // act1.DisplayEndingMessage();

        // Console.WriteLine("Breathing Activity...");
        // BreathingActivity act2 = new BreathingActivity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // act2.Run();

        Console.WriteLine("Listing Activity...");
        ListingActivity act3 = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
        act3.Run();
        
    }
}