using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string textString = text;

        String[] splitText = textString.Split(' ');

        foreach (string w in splitText)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // GetDisplayText();
        int n = numberToHide;


        for (int i = 1; i <= n; i++)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _words.Count);
            Console.WriteLine("this is a random number");
            Console.WriteLine(number);
        }
    }

    public string GetDisplayText()
    {

        // Word word = new Word(text);
        // foreach (Word word in _words)
        // {
        //     word.GetDisplayText();
        // }
        // return "";
        string displayVerse = "";
        foreach (Word w in _words)
        {
            displayVerse += w.GetDisplayText() + " ";
        }

        return displayVerse;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            w.HideAWord();
        }
        return true;
    }

}