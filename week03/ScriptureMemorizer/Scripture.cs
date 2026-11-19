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
        int numHide = numberToHide;
        List<int> ranList = new List<int>();
        Random random = new Random();
        int r = 0;

        for (int i = 1; i <= numHide; i++)
        {
            int ranNum = random.Next(1, _words.Count);
            ranList.Add(ranNum);
        }

        foreach (Word w in _words)
            foreach (int k in ranList)
            {
                _words[ranList[r]] = w.HideAWord();
            }
        GetDisplayText();
    }

    public string GetDisplayText()
    {
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
            //is w hidden? if so and all are hidden, 
        }
        return true;
    }
}
