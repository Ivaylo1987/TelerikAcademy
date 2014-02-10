using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    /* Modify the solution of the previous problem to replace only whole words (not substrings).
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
                    outputWriter.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));

                    line = inputReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Replaced! :)");
    }
}
