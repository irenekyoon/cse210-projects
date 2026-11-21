using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    //private File _filename;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, File filename)
    {
        _reference = reference;
        //_filename = filename;
        File file = new File("scripture.txt");
        string verse = file.loadScripture();
        string textString = verse;
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
        IsCompletelyHidden();
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
        return displayVerse;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
