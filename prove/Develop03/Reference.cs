using System;

class Reference
{
    // attributes
    private string verseStart, verseEnd, chapter, book;

    // constructor
    public Reference(string _book, string _chapter, string _verseStart)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = null;

    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;
    }

    public string GetReference()
    {
        if (verseEnd == null)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
        
    }

}