using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int menuUserInput = 0;
        int totalPoints = 0;
        
        List<Goal> goals = new List<Goal>();

        Console.WriteLine("Hello there! What is your name? ");
        string person = Console.ReadLine();

        Console.WriteLine($"Welcome, {person}, to the Goal Setter!");

        

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
            // totalPoints = _points
            Console.WriteLine($"Total Points Earned: {totalPoints}");
    
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
                GoalsMenu(goals);
                
            }

            else if (menuUserInput == 2)
            {
                // List Goals.
                Console.WriteLine("List goals...");
                
                foreach (Goal goal in goals)
                {
                    string summary = goal.GetGoalSummary();
                    Console.WriteLine(summary);
                }
                
                Console.WriteLine("Great list!"); 

            }

            else if (menuUserInput == 3)
            {
                // Save goals to a file.
                Goal.SaveToFile(totalPoints, goals);

                Console.WriteLine("Saving goals...");
            }

            else if (menuUserInput == 4)
            {

                // Load goals from a file.
                totalPoints = Goal.LoadFromFile(goals);
                
            }

            else if (menuUserInput == 5)
            {
                Console.WriteLine("Recording event...");    
                // Record Event.

                // list goals
            for (int i = 0; i < goals.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {goals[i].GetName()}");
                
            }
               int recordedGoal = int.Parse(Console.ReadLine());
               int points = goals[recordedGoal-1].RecordEvent();
               
                Console.WriteLine($"Congratulations! You have earned {points}!");
                totalPoints += points;

                Console.WriteLine($"You now have {totalPoints}.");
                    
            }

            else 
            {
                Console.WriteLine("Thank you for goaling today.");

                
            }
        } while (menuUserInput != 6);
    }

    public static void GoalsMenu(List<Goal> goals)
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
                Simple s = new Simple();
                s.CreateGoal();
                goals.Add(s);
                
            }

            else if (menuUserInput == 2)
            {
                // call Eternal Goals program.
                Eternal e = new Eternal();
                e.CreateGoal();
                goals.Add(e);

            }

            else if (menuUserInput == 3)
            {
                Checklist c = new Checklist();
                c.CreateGoal();
                goals.Add(c);
            }

        } while (menuUserInput != 4);
    }
    
}