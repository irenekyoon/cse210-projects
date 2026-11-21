using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

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
        string displayVerse = "";
        int numHide = numberToHide;
        List<int> ranList = new List<int>();
        Random random = new Random();

        for (int i = 1; i <= numHide; i++)
        {
            int indexRandom = random.Next(0, _words.Count);
            ranList.Add(indexRandom);
            _words[indexRandom].HideAWord();
        }
        foreach (Word w in _words)
        {
            displayVerse += w.GetDisplayText() + " ";
        }
        Console.WriteLine(displayVerse);
    }

    public string GetDisplayText()
    {
        // int indexRandom = 2;
        // int indexScripture = 0;
        string displayVerse = "";

        foreach (Word w in _words)
        {
            displayVerse += w.GetDisplayText() + " ";
        }
        Console.WriteLine("");
        //HideRandomWords(2);

        // foreach (Word w in _words)
        // {
        //     displayVerse += w.GetDisplayText() + " ";
        //     indexScripture = indexScripture + 1;
        //     do
        //         if (_words[indexScripture] == _words[indexRandom])
        //         {
        //             _words[indexScripture].HideAWord();
        //         }
        //     while (indexScripture < _words.Count);
        //     indexScripture = 0;

        // }
        return displayVerse;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            //is w hidden? if so and all are hidden, 
        }
        return true;
    }
}
