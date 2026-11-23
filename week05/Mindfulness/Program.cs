using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity act1 = new Activity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // act1.DisplayStartingMessage();
        // act1.DisplayEndingMessage();

        Console.WriteLine("Breathing Activity...");
        BreathingActivity act2 = new BreathingActivity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        act2.Run();
    }
}