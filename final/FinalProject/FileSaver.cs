using System;

public class FileSaver
{
    public static void SaveToFile(List<Quilt> quilts)
    {

        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            
            foreach (Quilt quilt in quilts)
            {
                outputFile.WriteLine(quilt.GetQuiltFormat());
    
            }
        }
        Console.WriteLine("Saved to file.");
    }
}