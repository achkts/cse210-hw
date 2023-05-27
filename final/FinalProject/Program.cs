using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

      int totalQuilts = 0;

      Console.WriteLine("Welcome to the Quilt Library!");

      Menu menu = new Menu();
      string menuRun = menu.RunMenu();
      Console.WriteLine(menuRun);






    // Make a quilts array to count for quilts.

      Console.WriteLine($"Total Quilts Made: {totalQuilts}");
    }


}