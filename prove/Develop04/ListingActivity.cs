using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> randomQuestions;


        public ListingActivity() : base ("Listing Activity", "This activity" + 
        " will help you reflect on the good things in your life by having"
        + " you list as many things as you can in a certain area.", 0)
        {
           randomQuestions = new List<string>()
           {
            "Who are the people that you appreciate?",
            "What are personal  strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",

           };

        }


        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(randomQuestions.Count);
            return randomQuestions[index];
        }

        public void RunActivity()
        {
            Console.WriteLine("Start Reflection Activity...");

            string randQ = this.GetRandomQuestion();
            Console.Write("\n" + randQ);

            this.GetSpinner();
            Console.WriteLine();
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(durationInSeconds);

            List<string> listEntries = new List<string>();


            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                listEntries.Add(Console.ReadLine());


            }
            
            Console.WriteLine($"You entered {listEntries.Count()} items!");
            


        }
}