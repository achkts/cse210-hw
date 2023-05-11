using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
            string studentSummary1 = assignment.GetSummary();

            Console.WriteLine(studentSummary1);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string studentSummary2 = mathAssignment.GetSummary();
        string homework1 = mathAssignment.GetHomeworkList();

        Console.WriteLine(studentSummary2);
        Console.WriteLine(homework1);

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string studentSummary3 = writing.GetSummary();
        string writingassign1 = writing.GetWritingInformation();

        Console.WriteLine(studentSummary3);
        Console.WriteLine(writingassign1);
    }

}