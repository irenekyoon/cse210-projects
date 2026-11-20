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
        int numHide = numberToHide;
        List<int> ranList = new List<int>();
        Random random = new Random();
        int indexWords = 0;
        foreach (Word w in _words)
        {
            for (int i = 1; i <= numHide; i++)
            {
                int ranNum = random.Next(1, _words.Count - 1);

                while (_words[ranNum] != _words[indexWords])
                {
                    _words[indexWords].ShowAWord();
                    if (indexWords < 8)
                    {
                        indexWords = indexWords + 1;
                    }
                }
                if (_words[ranNum] == _words[indexWords])
                {
                    _words[ranNum].HideAWord();
                }
            }
            break;
        }

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
