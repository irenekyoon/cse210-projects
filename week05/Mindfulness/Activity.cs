using System;
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
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayIntroMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string durString = Console.ReadLine();
        _duration = int.Parse(durString);
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity."); //_duration doesnt work
        DisplaySpinner();
    }

    public void DisplaySpinner()
    {
        //int seconds = 0;
        List<string> spinStrings = new List<string>();
        spinStrings.Add("/");
        spinStrings.Add("-");
        spinStrings.Add("\\");
        spinStrings.Add("|");
        spinStrings.Add("/");

        foreach (string s in spinStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}

