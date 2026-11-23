using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");

        Console.WriteLine($"This activity will help you {_description}");

        Console.WriteLine($"How long, in seconds, would you like for your session?");
        string durationString = Console.ReadLine();
        _duration = int.Parse(durationString);

        Console.Clear();

        Console.Write("Get ready...");
        ShowSpinner();
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well done!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}");
    }

    public void ShowSpinner()
    {
        //int seconds = 0;
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        // spinner.Add("/");
        // spinner.Add("-");
        // spinner.Add("\\");

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown()
    {
        //int seconds = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int j = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            j++;
        }

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

    }
}