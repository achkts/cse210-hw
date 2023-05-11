using System;

public class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;
    
    public MathAssignment(string _studentName, string _topic, string _textbookSection, string _problems) : base (_studentName, _topic)
    {
        textbookSection = _textbookSection;
        problems = _problems;

    }

    public string GetHomeworkList()
    {
        return $"Section {textbookSection} Problems {problems}";
    }


}