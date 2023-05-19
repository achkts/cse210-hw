using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int menuUserInput = 0;



        // Create menu and user input variables
        List<string> menu = new List<string>
        {

            "\nMenu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit",
            "\nWhat would you like to do? "
        };

        // While user input is not 6
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
                // Create new Goal.
                // Ask user which goal like to do.
                // 
                GoalsMenu();
                
            }

            else if (menuUserInput == 2)
            {
                // List Goals.
                Console.WriteLine("List goals...");
                Console.ReadLine();
                Console.WriteLine("Great list!"); 

            }

            else if (menuUserInput == 3)
            {
                // Save goals to a file.
                Console.WriteLine("Saving goals...");
            }

            else if (menuUserInput == 4)
            {
                // Load goals from a file.
                Console.WriteLine("Loading Goals...");
                
            }

            else if (menuUserInput == 5)
            {
                // Record Event.
                Console.WriteLine("Recording event...");
            }

            else 
            {
                Console.WriteLine("Thank you for goaling today.");

                
            }
        } while (menuUserInput != 6);
    }

    public static void GoalsMenu()
    {
         int menuUserInput = 0;

        // Create menu and user input variables
        List<string> goalMenu = new List<string>
        {

            "\nThe types of Goals are:",
            "1. Simple Goal",
            "2. Eternal Goals",
            "3. Checklist Goal",
            "4. Back to Main Menu",
            "\nWhich type would you like to create? "
        };

        do
        {
            foreach(string menuItem in goalMenu)
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
                Goals goal = new Goals();
                goal.GetQuestions();
                //1
                //ask title,desc,point
                //new SimpleGoal(name, desc, point)

                //2
                //s =new SimpleGoal()
                //s.AskDetails()


                // call  simple Goal
                Console.WriteLine("Running Simple Goal...");
                
            }

            else if (menuUserInput == 2)
            {
                // call Eternal Goals program.
                Console.WriteLine("Running Eternal Goal...");

            }

            else if (menuUserInput == 3)
            {
                // Call Checklist Goal program.
                Console.WriteLine("Running Checklist Goal...");
            }

        } while (menuUserInput != 4);
    }
    
}