using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            
        }
    }

    public void CreateJournalEntry()
    {
        // Load random prompt from PromptGenerator
        PromptGenerator prompt = new PromptGenerator();
        string promptRandom = prompt.GetRandomPrompt();
        Console.WriteLine(promptRandom);
        string response =  Console.ReadLine();
        DateTime todaysDate = DateTime.Today;
        string date = todaysDate.ToShortDateString();
        Entry entry = new Entry(date, promptRandom, response);
        entries.Add(entry);

    }
    public void SaveToCSV()
    {
        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetEntryAsCSV());
    
            }
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