using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void GuideBreathing()
    {
        DisplayIntroMessage();
        Console.WriteLine();
        DateTime timeStart = DateTime.Now;
        DateTime timeStop = timeStart.AddSeconds(GetDuration()); 
        while (DateTime.Now < timeStop)
        {
            Console.Write("Breathe in...");
            DisplayInhaleCount();
            Console.Write("Now breathe out ...");
            DisplayExhaleCount();
            Console.WriteLine();
        }
        DisplayEndMessage();
    }

    public void DisplayInhaleCount()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void DisplayExhaleCount()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}