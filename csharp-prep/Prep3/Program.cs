using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        string numberM = Console.ReadLine();
        int magicNumber = int.Parse(numberM);


        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        if (userGuess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (userGuess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }






    }
}