using System;
using System.Collections.Generic;

class Scripture
{
    private Reference scriptureReference;
    private List<Word> words;

    public Scripture(Reference _scriptureReference, string scripture)
    {
       scriptureReference = _scriptureReference;
       var scriptureWords = scripture.Split(" ");
       words = 
    }

    public void CreateWords()
    {

    }
    public string DisplayScripture()
    {

        return "";
    }

    public string RemoveWords()
    {
        return "";
    }

    public string WordsLeft()
    {
        return "";
    }

}
