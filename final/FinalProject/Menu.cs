using System;

public class Menu {

    protected int menuUserInput;

    public Menu()
    {

    }
        
        
        List<Quilt> quilts = new List<Quilt>();

        


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
               NewQuiltMenu questions = new NewQuiltMenu();
               Quilt newQuilt = questions.CreateQuilt();

               // add quilts to list.
               quilts.Add(newQuilt);

                Console.WriteLine("Adding new quilt...");
                Console.WriteLine($"Total quilts in library: {quilts.Count}");  
                
            }

            else if (menuUserInput == 2)
            {
                // List Quilts.
                Console.WriteLine("Listing quilts...");
                
                foreach (Quilt quilt in quilts)
                {
                    string summary = quilt.GetQuiltSummary();
                    Console.WriteLine(summary);
                }
                
                

            }

            else if (menuUserInput == 3)
            {
                // Save quilts to a file.
                // int totalQuilts = quilts.Count;

                FileSaver.SaveToFile(quilts);

        
            }

            else if (menuUserInput == 4)
            {

                // Load goals from a file.
                Console.WriteLine("Loading file of quilts....");
                FileLoader.LoadFromFile(quilts);
                Console.WriteLine("Loaded.");
                
            }

            else 
            {
               // Random Quilt quote.
               QuoteGenerator quote = new QuoteGenerator();
               string randQuote = quote.GetRandomQuote();
               Console.WriteLine(randQuote);

                           
            }

        } while (menuUserInput != 5);

        return $"Total Quilts: {quilts.Count}";
    }
}
