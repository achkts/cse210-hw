using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
            string sum = assignment.GetSummary();
    }

}