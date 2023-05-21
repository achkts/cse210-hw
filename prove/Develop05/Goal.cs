using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    protected DateTime _dateCreated = DateTime.Now;

    

    public Goal(string name, string description, int points, DateTime dateCreated)
    {
        _name = name;
        _description = description;
        _points = points;
        _dateCreated = dateCreated;

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

    public string GetName()
    {
        return _name;
    }

    public string GetDate()
    {
        return _dateCreated.ToString("yyyy-dd-MM");
    }

    // public abstract void ListGoal();
    public abstract string GetGoalSummary();

    public abstract string GetGoalFormat();
    

    public static void SaveToFile(int totalPoints, List<Goal> goals)
    {

        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine(totalPoints);

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalFormat());
    
            }
        }
        Console.WriteLine("Saved to file.");
    }

    
    public static int LoadFromFile(List<Goal> goals)
    {
        int totalPoints = 0;
        Console.WriteLine("What is the file you want to load? ");
        string filename = Console.ReadLine();

        Console.WriteLine("Loading Goals...");

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if(line.Contains(":"))
            {
               string[] splitLine = line.Split(':',',');

               if(splitLine[0] == "SimpleGoal")
               {
                goals.Add(new Simple(splitLine[2], splitLine[3], 
                int.Parse(splitLine[4]), bool.Parse(splitLine[5]), 
                DateTime.ParseExact(splitLine[1], "yyyy-dd-MM", CultureInfo.InvariantCulture)));
               }

                if(splitLine[0] == "EternalGoal")
               {
                goals.Add(new Eternal(splitLine[2], splitLine[3], 
                int.Parse(splitLine[4]), DateTime.ParseExact(splitLine[1], 
                "yyyy-dd-MM", CultureInfo.InvariantCulture)));
               }
               if(splitLine[0] == "ChecklistGoal")
               {
                goals.Add(new Checklist(splitLine[2], splitLine[3], 
                int.Parse(splitLine[4]), int.Parse(splitLine[5]),
                int.Parse(splitLine[6]), int.Parse(splitLine[7]), 
                DateTime.ParseExact(splitLine[1], "yyyy-dd-MM", CultureInfo.InvariantCulture)));
               }
            } 
            else 
            {
                totalPoints = int.Parse(line);
            }


        }
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetGoalSummary());
        }
        return totalPoints;
        
    }

    public abstract int RecordEvent();
   

    public abstract bool IsComplete();
   

   
    // public abstract double GetArea();


}