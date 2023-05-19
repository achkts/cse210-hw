using System;

public class Checklist : Goals
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

    public override bool IsComplete()
    {
        return true;
    }
}