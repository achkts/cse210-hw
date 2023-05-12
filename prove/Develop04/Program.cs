using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activty activity = new Activity();

        int menuUserInput = 0;

        // Create menu and user input variables
        List<string> menu = new List<string>
        {
            "\nPlease select one of the following choices:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit",
            "\nWhat would you like to do? "
        };

        // While user input is not 4
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
                Console.WriteLine("I'm sorry, I didn't understand that. Please try again.");
            }

            // Switch statement for user input.
            if (menuUserInput == 1)
            {
                // Start breathing activity.
                journal.CreateJournalEntry();
            }
            else if (menuUserInput == 2)
            {
                // Start reflecting activity.
                journal.DisplayJournalEntries();
            }
            else if (menuUserInput == 3)
            {
                // Start listing activity.
                journal.SaveToCSV();
            }
            else 
            {
                Console.WriteLine("Thank you for taking care of yourself today!");
            }
        } while (menuUserInput != 5);
    }
}