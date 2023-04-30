using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");


        Journal journal = new Journal();
        int menuUserInput = 0;

        // Create menu and user input variables
        List<string>    menu = new List<string>
        {
            "\nPlease select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
            "What would you like to do? "
        };

        // While user input is not 5
        do
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            try{
            menuUserInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                menuUserInput = 0;
                Console.WriteLine("I'm sorey, I didn't understand that. Please try again.");
            }

            // Switch statement for user input.
            if (menuUserInput == 1)
            {
                // Create journal entry using random prompt.
                journal.CreateJournalEntry();
            }
            else if (menuUserInput == 2)
            {
                // Display journal entries from Journal
                journal.DisplayJournalEntries();
            }
            else if (menuUserInput == 3)
            {
                // Save file to text file
                journal.SaveToCSV();
            }
            else if (menuUserInput == 4)
            {
                // Load file from text  file
                
                journal.LoadFromCSV();
            }
            else 
            {
                Console.WriteLine("Thanks for writing in your journal today!");
            }
        } while (menuUserInput != 5);

    }
}