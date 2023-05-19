using System;

public abstract class Goals
{
    private string _name;
    private string _description;
    private int _points;

    

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public Goals()
    {

    }

    public void GetQuestions()
    {

        Console.Write("What is the name of your goal? ");
        Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        Console.ReadLine();

        Console.Write("How many points is your goal worth? ");
        _points = int.Parse(Console.ReadLine());

        
    }

    public int RecordEvent()
    {
        return 0;
    }

    public abstract bool IsComplete();
   

   
    // public abstract double GetArea();


}