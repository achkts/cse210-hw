using System;
using System.Collections.Generic;

class Word
{
    // attributes
    private string word;
    private bool isHidden;

    // constructor
    public Word(string _word)
    {
        word = _word;
        isHidden = false;

    }

    public bool GetHidden()
    {
        return isHidden;
    }

    public void SetHiddenWord(bool _isHidden)
    {
        isHidden = _isHidden;
    }

    public string GetWord()
    {
        return word;
    }
}