using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public Goal()
    {

    }

    public virtual void CreateGoal()
    {

        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("How many points is your goal worth? ");
        _points = int.Parse(Console.ReadLine());

        
    }

    // public abstract void ListGoal();
    public abstract string GetGoalSummary();
    

    public void SaveToCSV()
    {
        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalSummary());
    
            }
        }
        Console.WriteLine("Saved to file.");
    }

    public void LoadFromCSV()
    {
        Console.WriteLine("What is the file you want to load? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
    }

    public abstract int RecordEvent();
   

    public abstract bool IsComplete();
   

   
    // public abstract double GetArea();


}