using System;
public class TimeLeft

{
    public static DateTime endOfYear = DateTime.Parse("12/31/2026");
    public static TimeSpan timeLeft = DateTime.Now.Subtract(endOfYear);

    public void DisplayTimeLeft()
    {
        Console.WriteLine($"There are {timeLeft.Days} days left in the year.");
        Console.WriteLine("Keep it up 'for the day that [you], and those that [you] love,'");
        Console.WriteLine("will need to remember how much God loves us and how much we need Him'");
        Console.WriteLine("President Henry B. Eyring, 'O Remember, Remember')");
    }

}