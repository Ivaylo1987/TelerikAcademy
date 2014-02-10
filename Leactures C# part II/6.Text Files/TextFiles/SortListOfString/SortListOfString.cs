using System;
using System.Collections.Generic;
using System.IO;

class SortListOfString
{
    /* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
     */

    static List<String> ReadInputString(string fileLocation)
    {
        using (StreamReader inpuStream = new StreamReader(fileLocation))
        {
            List<String> listofNames = new List<string>();
            string line = inpuStream.ReadLine();

            while (line != null)
            {
                listofNames.Add(line.Trim());

                line = inpuStream.ReadLine();
            }

            listofNames.Sort();

            return listofNames;
        }
    }

    static void Main()
    {
        string fileLocation = @"..\..\input.txt";
        List<String> result = ReadInputString(fileLocation);

        StreamWriter outPut = new StreamWriter(@"..\..\output.txt");

        foreach (var sortedItem in result)
        {
            outPut.WriteLine(sortedItem);
        }

        Console.WriteLine("Output written to file!");
        outPut.Dispose();
    }

     
}
