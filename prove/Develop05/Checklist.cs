using System;

public class Checklist : Goal
{
    private int _bonusPoints;
    private int _goalCompletion;
    private int _progress;

    public Checklist(string name, string description, 
    int points, int bonusPoints, int goalCompletion, int progress) : 
    base (name, description, points)
    {
        _bonusPoints = bonusPoints;
        _goalCompletion = goalCompletion;
        _progress = progress;

    }

    public Checklist()
    {

    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        Console.ReadLine();
         _goalCompletion = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        Console.ReadLine();
         _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override string GetGoalSummary()
    {
        if (IsComplete() == true)
        {
            return $"[X]  {_name} ({_description}) -- Completed: {_progress}/{_goalCompletion}";
        }
        else 
        {
            return $"[ ]  {_name} ({_description}) -- Completed: {_progress}/{_goalCompletion}";
        }
    }

    public override bool IsComplete()
    {
        return _progress >= _goalCompletion;
    }

    public override int RecordEvent()
    {
        _progress++;
        
        if (IsComplete() == true)
        {
            return _bonusPoints;
        }
        else
        {
            return _points;
        }
        
    }
}