using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        // Console.Write("What is the magic number? ");
        // string numberM = Console.ReadLine();
        // int magicNumber = int.Parse(numberM);
        var rand = new Random();


        string response;
        Console.WriteLine("Welcome to the number guessing game!");

        do
        {
            int magicNumber = rand.Next(1, 100);


            int userGuess = -1;
            int guessCount = 0;

            do
            {

                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                userGuess = int.Parse(guess);
                guessCount = guessCount + 1;

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
                    Console.WriteLine($"It took you {guessCount} guesses to get it correct.");
                }
            } while (userGuess != magicNumber);

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");





    }
}