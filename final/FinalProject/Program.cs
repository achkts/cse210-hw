using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

      Console.WriteLine("Welcome to the Quilt Library!");

      Menu menu = new Menu();
      string menuRun = menu.RunMenu();
      Console.WriteLine(menuRun);

      

    }


}