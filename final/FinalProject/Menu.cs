using System;

public class Menu {

    protected int menuUserInput;

    public Menu()
    {

    }
        int _menuUserInput = 0;
        
        List<Quilt> goals = new List<Quilt>();


    public string RunMenu()
    {

        // Create menu and user input variables
        List<string> menu = new List<string>
        {
            "\nQuilt Library Options:",
            "1. Add New Quilt",
            "2. List Quilts",
            "3. Save Quilts",
            "4. Load Quilts",
            "5. Quit Library",
            "\nWhat would you like to do? "
        };

        // While user input is not 5
        do
        {   
            // totalPoints = _points
            
    
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
                // Add new Quilt.
               Console.WriteLine("Adding new quilt...");
                
            }

            else if (menuUserInput == 2)
            {
                // List Quilts.
                Console.WriteLine("Listing quilts...");
                
                // foreach (Quilt quilt in quilts)
                // {
                //     string summary = quilt.GetQuiltSummary();
                //     Console.WriteLine(summary);
                // }
                
                

            }

            else if (menuUserInput == 3)
            {
                // Save quilts to a file.
                // Quilts.SaveToFile(totalQuilts, quilts);

                Console.WriteLine("Saving quilts...");
            }

            else if (menuUserInput == 4)
            {

                // Load goals from a file.
                // totalQuilts = Quilts.LoadFromFile(quilts);
                Console.WriteLine("Loading quilts....");
                
            }

            else 
            {
               // Random Quilt quote.
               QuoteGenerator quote = new QuoteGenerator();
               string randQuote = quote.GetRandomQuote();
               Console.WriteLine(randQuote);

               // How many quilts recorded.

                
            }

        } while (menuUserInput != 5);

        return "";
    }
}
