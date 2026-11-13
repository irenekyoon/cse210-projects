using System;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text) // reference variable is Reference in lesson
    {
        _reference = reference;
        string textString = text;

        Console.WriteLine(_reference.GetDisplayOneVerse());
        String[] splitText = textString.Split(' ');
        Console.WriteLine(splitText);
    }

    public void HideRandomWords(int numberToHide)
    {
        int n = numberToHide;

        for (int loops = 0; loops < n; loops++)
        {
            Random randomGenerator = new Random();
            int i = _words.Count;
            int number = randomGenerator.Next(0, i);

        }



    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}