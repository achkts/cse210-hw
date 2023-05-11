using System;

public class Assignment
{
    protected string studentName;
    protected string topic;


    public Assignment(string _studentName, string _topic)
    {
        studentName = _studentName;
        topic = _topic;

    }
    
    public string GetSummary()
    {
        
        return $"{studentName} - {topic}";
    }
}