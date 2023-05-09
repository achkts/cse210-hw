using System;
using System.Collections.Generic;


class Scripture
{
    private Reference scriptureReference;
    private List<Word> words;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
       scriptureReference = _scriptureReference;
       words = new List<Word>();
       CreateWords(_scriptureText);
    
    }

    public void CreateWords(string _scriptureText)
    {
        List<string> allWords = _scriptureText.Split(' ').ToList();
        foreach(string text in allWords)
        {
            Word word = new Word(text);
            words.Add(word);
        }
    }
    public string DisplayScripture()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetWord() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetWord().Length) + " ";
            }
        }
        return ($"{scriptureReference.GetReference()} {scriptureText}");
    }

    public void RemoveWords()
    {
        int numberWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;
        
        do
        {
            int randomIndex = new Random().Next(0, words.Count());

            if (words[randomIndex].GetIsHidden() == false)
            {
                words[randomIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numberWordsToRemove && this.HasWordsLeft() == true);
    }

    public bool HasWordsLeft()
    {
       
        bool anyWordsVisible = false;
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                anyWordsVisible = true;
            }
        }
        return anyWordsVisible;
    }

}
