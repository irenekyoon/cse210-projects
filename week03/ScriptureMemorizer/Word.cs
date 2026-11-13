using System;

public class Word
{
    private string _text = "";
    private bool _isHidden;

    Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void HideAWord()
    {
        _text = "_______";
        // _isHidden = true;
    }

    public void ShowAWord()
    {
        _text = "";
        // _isHidden = false;
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        if (IsHidden() == true)
        {
            return "_____";
        }

        else
        {
            return _text;
        }
    }

}