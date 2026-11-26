using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>() { "Why is it good to be alive at this moment in time?", "What blessings have you received from reading the Book of Mormon?", "What blessings have you experienced from Family History and Temple work?", "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private int _count = 0;
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void GuideListing()
    {
        DisplayIntroMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in:");
        DisplayCountdown();
        GetRandomPrompt();
        GetUserList();
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 7);

        return _prompts[number];
    }

    public void GetUserList()
    {
        DateTime timeStart = DateTime.Now;
        DateTime timeStop = timeStart.AddSeconds(GetDuration()); 
        while (DateTime.Now < timeStop)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
}