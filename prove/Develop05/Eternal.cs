using System;

public class Eternal : Goals
{
    

    public Eternal(string name, string description, int points) : 
    base (name, description, points)
    {
        

    }

    public override bool IsComplete()
    {
        return true;
    }
}