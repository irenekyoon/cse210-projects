using System;
using System.Numerics;

public class ListingActivity : Activity

{
    private int _count = 0;
    private List<string> _prompts = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        Console.WriteLine($"-- {_prompts[number]} --");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("< ");
            string userResponse = (Console.ReadLine());
            userList.Add(userResponse);
            _count += 1;
        }

        return userList;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        for (int i = 5; i >5; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        ShowCountDown();
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}