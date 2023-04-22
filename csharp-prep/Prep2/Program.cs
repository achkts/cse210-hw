using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your percentage? ");
        string userPercentage = Console.ReadLine();
        int percentage = int.Parse(userPercentage);

        string letter = "";

        int lastDigit = percentage % 10;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (lastDigit >= 7)
        {
            letter = letter + "+";
        }
        else if (lastDigit < 3)
        {
            letter = letter + "-";
        }
        if (letter == "A+" || letter == "F-" || letter == "F+")
        {
            letter = letter.Substring(0, 1);
        }

        Console.WriteLine($"Your letter grade: {letter}");


        if (letter.StartsWith("A") || letter.StartsWith("B") || letter.StartsWith("C"))
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Sorry, but you didn't pass the class. Please try again.");
        }
    }
}