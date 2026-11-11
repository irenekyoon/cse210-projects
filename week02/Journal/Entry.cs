using System;
public class Entry
{
    public static DateTime dateToday = DateTime.Now;
    public static string today = dateToday.ToLongDateString();

    public string _date = today;

    public string _prompt = "";

    public string _entry = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine("");
    }
}