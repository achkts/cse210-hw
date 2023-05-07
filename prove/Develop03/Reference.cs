using System;

class Reference
{
    // attributes
    private string _verseStart, _verseEnd, _chapter, _book;

    // constructor
    public Reference(string _book, string _chapter, string _verseStart)
    {
        string book = _book;
        string chapter = _chapter;
        string verseStart = _verseStart;

    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        string book = _book;
        string chapter = _chapter;
        string verseStart = _verseStart;
        string verseEnd = _verseEnd;
    }

    public GetReference()
    {
        return " ";
    }

}