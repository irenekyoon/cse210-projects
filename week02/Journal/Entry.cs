using System;
public class Entry
{
    public static DateTime dateToday = DateTime.Now;
    public static string today = dateToday.ToShortDateString();
    public string _date = today;

    public string _prompt = "What is one thing that went well today?";
    public string _entry = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine("");
    }
}