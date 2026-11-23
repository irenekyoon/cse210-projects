using System;

public class BreathingActivity : Activity

{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        //Console.WriteLine($"startTime: {startTime}");
        //Console.WriteLine($"endTime: {endTime}");
        DateTime currentTime = DateTime.Now;
        //Console.WriteLine($"currentTime: {currentTime}");
        while (currentTime < endTime)
        {
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            Console.Write("Breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}