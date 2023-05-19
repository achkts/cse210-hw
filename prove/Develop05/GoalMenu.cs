using System;

public class GoalMenu
{

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