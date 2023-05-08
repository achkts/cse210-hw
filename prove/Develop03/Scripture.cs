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

    public void RemoveWords()
    {
        int numberWordsToRemove = new Random().Next(3, 5);
        int wordsRemoved = 0;
        
        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            if (words[rndIndex].GetIsHidden() == false)
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numberWordsToRemove && this.HasWordsLeft());
    }

    public string HasWordsLeft()
    {
       
        return "";
        
    }

}
