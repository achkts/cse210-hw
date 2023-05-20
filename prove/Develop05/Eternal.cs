using System;

public class Eternal : Goal
{
    

    public Eternal(string name, string description, int points, bool completed) : 
    base (name, description, points)
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

    public override bool IsComplete()
    {
        return false;
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