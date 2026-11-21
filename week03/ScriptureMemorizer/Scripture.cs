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
        Random random = new Random();
        //int indexScripture = 0;

        int indexRandom = random.Next(0, _words.Count);
        for (int i = 1; i <= numHide; i++)
        {
            _words[indexRandom].HideAWord();
        }


        // foreach (Word word in _words)
        // {
        //     do
        //     {
        //         if (indexScripture )
        //         indexScripture = indexScripture + 1;
        //     }
        //     while (indexScripture > _words.Count);

        // }


        // int numHide = numberToHide;
        // List<int> ranList = new List<int>();
        // Random random = new Random();
        // int indexWords = 0;
        // foreach (Word w in _words)
        // {
        //     for (int i = 1; i <= numHide; i++)
        //     {
        //         int ranNum = random.Next(0, _words.Count);
        //         if (_words[ranNum] != _words[indexWords])
        //         {
        //             _words[indexWords].ShowAWord();

        //             if (indexWords < _words.Count)
        //             {
        //                 if (indexWords == _words.Count - 1)
        //                 {
        //                     indexWords = 0;
        //                     break;
        //                 }
        //                 indexWords = indexWords + 1;
        //             }
        //         }
        //         else if (_words[ranNum] == _words[indexWords])
        //         {
        //             _words[ranNum].HideAWord();
        //             if (indexWords < _words.Count)
        //             {
        //                 if (indexWords == _words.Count - 1)
        //                 {
        //                     indexWords = 0;
        //                     break;
        //                 }
        //                 indexWords = indexWords + 1;
        //             }
        //             break;
        //         }
        //         //break;
        //     }
        // }
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
        HideRandomWords(2);

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
