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
        int n = numberToHide;
        Random randomGenerator = new Random();

        for (int i = 1; i <= n; i++)
        {
            int number = randomGenerator.Next(0, _words.Count);
            Console.WriteLine(number);
            _words[number].HideAWord();
            _words[number].IsHidden();
        }
    }

    public string GetDisplayText()
    {
        string displayVerse = "";
        foreach (Word w in _words)
        {
            displayVerse += w.GetDisplayText() + " ";
        }
        // HideRandomWords(4);

        return displayVerse;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {

        }
        return true;
    }

}