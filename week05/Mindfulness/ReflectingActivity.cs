using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>(){"Think of a time when you were so angry with someone, yet you were able to forgive that person.", "Think of a time when you were discouraged and felt like giving up, but you persevered anyways.",
"Think of a time when you overcame a fear.", "Think of a time when you were pressured to do something wrong, but you didn't give in to it.", "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void GuideReflecting()
    {
        DisplayIntroMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} --- ");
        DisplayLongSpinner();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown();
        DisplayQuestions();
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 7);

        return _prompts[number];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 8);

        return _questions[number];
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            DisplaySpinner();
            Console.WriteLine();
        }
    }

    public void DisplayLongSpinner()
    {
        List<string> spinStrings = new List<string>();
        spinStrings.Add("/");
        spinStrings.Add("-");
        spinStrings.Add("\\");
        spinStrings.Add("|");
        spinStrings.Add("/");
        spinStrings.Add("-");
        spinStrings.Add("\\");
        spinStrings.Add("|");

        foreach (string s in spinStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
