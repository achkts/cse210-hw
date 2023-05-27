using System;
using System.Globalization;


public class FileLoader{


    public static int LoadFromFile(List<Quilt> quilts)
            {
                int totalQuilts = 0;
                Console.WriteLine("What is the file you want to load? ");
                string filename = Console.ReadLine();

                Console.WriteLine("Loading Quilts...");

                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    // if(line.Contains(":"))
                    // {
                    // string[] splitLine = line.Split(':',',');

                    // if(splitLine[0] == "name")
                    // {
                    //     quilts.Add(new Quilt(splitLine[2], splitLine[3], 
                    //     int.Parse(splitLine[4]), bool.Parse(splitLine[5]);
                    // }

                    // else 
                    // {
                    //     totalQuilts = int.Parse(line);
                    // }


                }
                foreach (Quilt quilt in quilts)
                {
                    Console.WriteLine(quilt.GetQuiltSummary());
                }
                return totalQuilts;
                
            }
}