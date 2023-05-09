using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        
        Scripture scripture = new ScriptureGenerator().GetRandomScripture();

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            // Display scripture
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.DisplayScripture());
        Console.WriteLine("Congratulations on your hard work. May you always remember!");
    }

}