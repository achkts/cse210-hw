using System;

public class BreathingActivity : Activity
{
    private int breatheInSeconds;
    private int breatheOutSeconds;
    private int holdBreatheSeconds;

    // Constructor
    public BreathingActivity(int _breatheInSeconds, int _breatheOutSeconds, int _holdBreatheSeconds) : 
        base("Breathing Activity", "\nThis activity will help you relax by walking" +
        " your through breathing in and out slowly. Clear your mind and focus on" +
        " your breathing.", 0)
    {
        breatheInSeconds = _breatheInSeconds;
        breatheOutSeconds = _breatheOutSeconds;
        holdBreatheSeconds = _holdBreatheSeconds;
    }

    public void RunActivity()
    {

        Console.Write("Start Breathing activity...");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in for... ");
            this.CountDownClock(breatheInSeconds);

            Console.Write("Hold breath for... ");
            this.CountDownClock(holdBreatheSeconds);

            Console.Write("\nBreathe out for... ");
            this.CountDownClock(breatheOutSeconds);
            
        } 
        

        
    }
}