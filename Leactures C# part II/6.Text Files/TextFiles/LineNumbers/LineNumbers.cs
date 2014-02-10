using System;
using System.IO;

class LineNumbers
{
    /* Write a program that reads a text file and inserts line numbers in front of each of its lines.
     * The result should be written to another text file.
     */
    static void Main()
    {
        using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt", false))
        {
            string line = null;
            using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
            {
                line = inputReader.ReadLine();
                int count = 0;

                while (line != null)
                {
                    count++;
                    outputWriter.WriteLine("Line {0} - {1}", count, line);

                    line = inputReader.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}
