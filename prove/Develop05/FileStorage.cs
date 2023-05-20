using System;
using System.Collections.Generic;
using System.IO;

public class FileStorage
{
    // save to file.
    // public void CreateGoal()
    // {
    //     // Load random prompt from PromptGenerator
    //     PromptGenerator prompt = new PromptGenerator();
    //     string promptRandom = prompt.GetRandomPrompt();
    //     Console.WriteLine(promptRandom);
    //     string response =  Console.ReadLine();
    //     DateTime todaysDate = DateTime.Today;
    //     string date = todaysDate.ToShortDateString();
    //     Entry entry = new Entry(date, promptRandom, response);
    //     entries.Add(entry);

    // }
    public void SaveToCSV()
    {
        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            // foreach (Goals goal in goals)
            // {
            //     outputFile.WriteLine(entry.GetEntryAsCSV());
    
            // }
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

}