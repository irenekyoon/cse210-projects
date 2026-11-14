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

    // public string GetText()
    // {
    //     return _text;
    // }
    // public void SetText(string text)
    // {
    //     _text = text;
    // }
    public void HideAWord()
    {
        _text = "_______";
        _isHidden = true;
    }

    public void ShowAWord()
    {
        _text = "";
        _isHidden = false;
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
            return "_______";
        }
    }

}