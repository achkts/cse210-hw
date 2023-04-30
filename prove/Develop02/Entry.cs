using System;
using System.Collections.Generic;
using System.IO;


class Entry
{

    // attributes
    string date, prompt, response;


    // constructor
    public Entry(string _date, string _prompt, string _response)
    {
       date = _date;
       prompt = _prompt;
       response = _response;

    }

    // display and format the three attributes and way shown when printed
    public void DisplayEntry()
    {
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        Console.WriteLine(response);

    }

    // method that will get entry object and return as csv record
    public string GetEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }

















}

