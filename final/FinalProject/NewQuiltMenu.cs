using System;
using System.Collections.Generic;

public class NewQuiltMenu : Menu
{
    public virtual Quilt CreateQuilt()
        {
            Console.Write("What is the name of your quilt? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
             string description = Console.ReadLine();

            Console.Write("What year was it created? ");
            int yearCreated = int.Parse(Console.ReadLine());

            Console.Write("What is the length(in inches) of your quilt? ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("What is the width(in inches) of your quilt? ");
            int width = int.Parse(Console.ReadLine());

            Fabric fabric = GetFabric();

            string pattern = GetPatternName(); 

            Console.WriteLine("Is this a quilt for a bed (yes/no)? ");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Who was this gifted to? ");
                string giftName = Console.ReadLine();

                int giftedYear = 0;

                if (giftName != "")
                {
                    Console.WriteLine("What year was this given? ");
                    giftedYear = int.Parse(Console.ReadLine());
                }
                
                Quilt quilt = new BedQuilts(name, description, yearCreated, length, width, fabric, giftName, giftedYear);

                return quilt;
                
            }
            else
            {
                Console.WriteLine("Who taught this? ");
                string taughtBy = Console.ReadLine();

                Console.WriteLine("Where was this taught? ");
                string taughtAt = Console.ReadLine();
                

                Quilt quilt = new DisplayQuilts(name, description, yearCreated, length, width, fabric, taughtBy, taughtAt);
                return quilt;
            }

            
        }

        public Fabric GetFabric()
    {
        Console.WriteLine("What is the type of fabric used? ");
        string fabricType = Console.ReadLine();

        Console.WriteLine("Who is the fabric designer? ");
        string fabricDesigner = Console.ReadLine();

        return new Fabric(fabricType, fabricDesigner);
    }

    public string GetPatternName()
    {
        Console.WriteLine("What pattern did you use? ");
        string patternName = Console.ReadLine();
        return $"Pattern Used: {patternName}";
    } 
}