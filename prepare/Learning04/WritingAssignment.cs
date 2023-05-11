using System;

public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string _studentName, string _topic, string _title) : base(_studentName, _topic)
    {
        title = _title;
    }

    public string GetWritingInformation()
    {
        return $"{title} by {studentName}";
    }
}