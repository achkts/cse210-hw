using System;

public class Simple : Goal
{
    private bool _completed;

    public Simple(string name, string description, int points, bool completed) : 
    base (name, description, points)
    {
        _completed = completed;

    }

    public Simple()
    {

    }

    public override string GetGoalSummary()
    {
        if (IsComplete() == true)
        {
            return $"[X]  {_name}, {_description}";
        }
        else 
        {
            return $"[ ]  {_name}, {_description}";
        }
        
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        if (IsComplete() == true)
        {
            return _points;
        }
        else
        {
            return 0;
        }
        
    }

}
