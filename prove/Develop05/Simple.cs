using System;

public class Simple : Goal
{
    private bool _completed;

    public Simple(string name, string description, int points, bool completed, DateTime dateCreated) : 
    base (name, description, points, dateCreated)
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
            return $"[X]  {_name} ({_description})";
        }
        else 
        {
            return $"[ ]  {_name} ({_description})";
        }
        
    }

    public override string GetGoalFormat()
    {
        return $"SimpleGoal:{this.GetDate()},{_name},{_description},{_points},{_completed}";
    }


    public override bool IsComplete()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }

}
