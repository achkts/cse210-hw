using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    // Constructor
    public ReflectionActivity() : 
        base("Reflection Activity", "\nThis activity will help you reflect on times" +
        " in your life when you have shown strength and resilience." + 
        " This will help you recognize the power you have and how you can use" +
        " it in other aspects of your life.", 0)
        {
         prompts = new List<string>()
           {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you helped someone in need.",
            
           };

           questions = new List<string>()
           {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?",

           };

        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            return questions[index];
        }
    

        public void RunActivity()
        {
            Console.WriteLine("Start Reflection Activity...");
            
            string randomPrompt = this.GetRandomPrompt();
            Console.WriteLine(randomPrompt);


            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(durationInSeconds);

            while (DateTime.Now < endTime)
            {
            
                string randomQuestion = this.GetRandomQuestion();
                Console.Write("\n" + randomQuestion);

                this.GetSpinner(10);

            }


        }
}