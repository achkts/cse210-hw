using System;

public class Eternal : Goal
{
    

    public Eternal(string name, string description, int points, DateTime dateCreated) : 
    base (name, description, points, dateCreated)
    {
        

    }

    public Eternal()
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
        return $"EternalGoal:{this.GetDate()},{_name},{_description},{_points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _points;
        
    }
}