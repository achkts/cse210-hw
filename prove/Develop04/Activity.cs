using System;

public class Activity
{
    // Attributes:
    protected string activityName;
    protected string description;
    protected int durationInSeconds;
    protected List<string> quotes;

    
    // Constructor
    public Activity(string _activityName, string _description, int _durationInSeconds)
    {
        activityName = _activityName;
        description = _description;
        durationInSeconds = _durationInSeconds;
        

        quotes = new List<string>()
           {
            "'Quiet the mind and the soul will speak.' ~ Ma Jaya Sati Bhagavati",
            "'Meditation is not about stopping thoughts, but recognizing that we" 
            + " are more than our thoughts and our feelings.' ~ Arianna Huffington",
            "'Learn to be calm and you will always be happy' ~ Paramahansa Yogananda",
            "'Empty your mind, be formless, shapeless—like water. Now you put water"
            + " into a cup, it becomes the cup, you put water into a bottle, it becomes"
            + " the bottle, you put it in a teapot, it becomes the teapot. Now water"
            + " can flow or it can crash. Be water, my friend.' ~ Bruce Lee",
            "'Meditation is the ultimate mobile device; you can" 
            + " use it anywhere, anytime, unobtrusively.' ~ Sharon Salzberg",
            "'If it is out of your hands, it deserves freedom from your mind too.' ~ Ivan Nuru",
            "'The way you speak to yourself matters.' ~ Unknown",
            "'The two most powerful warriors are patience and time.' ~ Leo Tolstoy",
            
           };

    }
    // Display starting message.
    public void GetStartMessage()
    {
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine($"{description}");

        Console.Write("\nHow long, in seconds, would you like your session? ");
        durationInSeconds = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet Ready");
    }

    // Display ending message.
    public void GetEndMessage()
    {
        Console.WriteLine("\n\nThank you for taking care of yourself today!");
    }

    // Pause while showing a spinner.
    public void GetSpinner(int spinnerDuration = 3)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinnerDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    
    }
    // Pausing while showing a countdown timer.
    public void CountDownClock(int _durationInSeconds)
    {
        for (int i = _durationInSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string GetInspirationalQuotes()
    {
        Random random = new Random();
        int index = random.Next(quotes.Count);
        return quotes[index];
    }

}