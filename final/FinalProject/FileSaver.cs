using System;

public class FileSaver
{
    public void SaveToFile(int totalQuilts, List<Quilt> quilts)
    {

        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine(totalQuilts);

            foreach (Quilt quilt in quilts)
            {
                outputFile.WriteLine(quilt.GetQuiltFormat());
    
            }
        }
        Console.WriteLine("Saved to file.");
    }
}