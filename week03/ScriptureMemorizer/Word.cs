using System;

public class Word
{
    private string _text = "";
    private bool _isHidden;

    public Word()
    {

    }
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
        string text = "";
        for (int i = 0; i < _text.Length; i++)
        {
            text += "_";
        }
        text = text + " ";
        _text = text;
    }

    public void ShowAWord()
    {
        Console.WriteLine(_text);
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            HideAWord();
        }
        return "";
    }
}