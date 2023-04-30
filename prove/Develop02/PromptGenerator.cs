class PromptGenerator
{
        List<string> prompts;

        public PromptGenerator()
        {
           prompts = new List<string>()
           {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If I could talk to one person for advice, who would it be and why?",
            "What was the best counsel I shared today?",
            "What is my testimony today?",
            "Free write (anything you want to say)"
           };

        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
}