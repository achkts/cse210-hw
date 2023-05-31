using System;
using System.Globalization;



public class FileLoader
{


    public static void LoadFromFile(List<Quilt> quilts)
            {
                
                Console.WriteLine("What is the file you want to load? ");
                string filename = Console.ReadLine();

                Console.WriteLine("Loading Quilts...");

                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    if(line.Contains(":"))
                    {
                        string[] splitLine = line.Split(':','|');

                        if(splitLine[0] == "Bed Quilt")
                        {
                            quilts.Add(new BedQuilts(splitLine[1], splitLine[2], 
                            int.Parse(splitLine[3]), int.Parse(splitLine[4]), int.Parse(splitLine[5]), 
                            new Fabric(splitLine[6], splitLine[7]), splitLine[8], int.Parse(splitLine[9])));
                        }
                        if(splitLine[0] == "Display Quilt")
                        {
                            quilts.Add(new DisplayQuilts(splitLine[1], splitLine[2], 
                            int.Parse(splitLine[3]), int.Parse(splitLine[4]), int.Parse(splitLine[5]), 
                            new Fabric(splitLine[6], splitLine[7]), splitLine[8], splitLine[9]));
                        }
                    }


                }
                foreach (Quilt quilt in quilts)
                {
                    Console.WriteLine(quilt.GetQuiltSummary());
                }


                Console.WriteLine($"Total Quilts Made: {quilts.Count}");
                
                
            }
    
   
}