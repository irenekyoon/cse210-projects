using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act1 = new Activity("Breathing", "Help you with Breathing");
        act1.DisplayStartingMessage();
        act1.DisplayEndingMessage();
    }
}