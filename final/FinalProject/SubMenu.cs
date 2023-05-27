using System;
using System.Collections.Generic;

public class SubMenu : Menu
{
    public virtual void CreateQuilt()
        {

            Console.Write("What is the name of your quilt? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
             string description = Console.ReadLine();

            Console.Write("What year was it created? ");
            int yearCreated = int.Parse(Console.ReadLine());

            Console.Write("What is the length of your quilt? (in inches)");
            int length = int.Parse(Console.ReadLine());

            Console.Write("What is the width of your quilt? (in inches)");
            int width = int.Parse(Console.ReadLine());

            // Quilt quilt = new Quilt(name, description, yearCreated, length, width);
        }
}