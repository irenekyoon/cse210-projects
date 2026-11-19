using System;

public class Word
{
    private string _text = "";
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public void HideAWord()
    {
        IsHidden();
        String[] letters = _text.Split(' ');
        foreach (string l in letters)
        {
            Console.WriteLine("_");
        }

    }

    public void ShowAWord()
    {
        Console.WriteLine(_text);
        // String[] letters = _text.Split(' ');
        // foreach (string l in letters)
        // {
        //     Console.WriteLine(l);
        // }
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            // string display = ShowAWord(); //Error: Cannot implicitly convert type 'void' to 'string'
            ShowAWord();
        }
        else
        {
            HideAWord();
        }
        return "";
    }
}