using System;

public class Simple : Goals
{
    private bool _completed;

    public Simple(string name, string description, int points, bool completed) : 
    base (name, description, points)
    {
        _completed = completed;

    }
    

    public override bool IsComplete()
    {
        return true;
    }

}
