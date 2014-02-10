using System;
using System.IO;

class ReplaceStringStart
{
    /* Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
     * Ensure it will work with large files (e.g. 100 MB).
     */
    static void Main()
    {
        using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
            {
                string line = inputReader.ReadLine();

                while (line != null)
                {
                    line = line.Replace("start", "finish");

                    outputWriter.WriteLine(line);

                    line = inputReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Replaced! :)");
    }
}
