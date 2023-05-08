using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference("John", "3", "16");
        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world, that he gave his sonly begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        "");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine();
            Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.DisplayScripture());
        Console.WriteLine("Congratulations on your hard work. May you always remember!");
    }

}