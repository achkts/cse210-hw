using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!"); 


        // Create a list of numbers.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        // Loop and ask user for numbers until 0.
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
           if (number != 0)
           {
            // Add numbers to list. 
            numbers.Add(number);
           }

        } while (number != 0);
        
        


        // Compute the Sum of the numbers in the list.
        int total = 0;
        foreach (int n in numbers)
        {
           total += n;
        }
        Console.WriteLine($"The sum is: {total}");
        

        // Compute the average of the numbers in the list.
        
        double average = total / (double)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number in the list.

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");


    }
}