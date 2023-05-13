using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");


        int menuUserInput = 0;

        // Create menu and user input variables
        List<string> menu = new List<string>
        {
            "\nMenu Options:",
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
                BreathingActivity activity = new BreathingActivity(5, 5, 5);
                activity.GetStartMessage();
                activity.GetSpinner();
                activity.RunActivity();
                activity.GetEndMessage();
                
            }

            else if (menuUserInput == 2)
            {
                // Start reflecting activity.
                ReflectionActivity activity = new ReflectionActivity();
                activity.GetStartMessage();
                Console.WriteLine("\n");
                activity.GetSpinner();
                activity.RunActivity();
                activity.GetEndMessage();

            }

            else if (menuUserInput == 3)
            {
                // Start listing activity.
                ListingActivity activity = new ListingActivity();
                activity.GetStartMessage();
                Console.WriteLine("\n");
                activity.GetSpinner();
                activity.RunActivity();
                activity.GetEndMessage();
            }

            else 
            {
                Activity activity = new Activity("", "", 0);
                string quotes = activity.GetInspirationalQuotes();
                Console.WriteLine(quotes);

                
            }
        } while (menuUserInput != 4);
    }
}