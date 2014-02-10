using System;
using System.IO;

class PrintOddLines
{
    /* Write a program that reads a text file and prints on the console its odd lines.
     */
    static void Main()
    {
        using (StreamReader inputReder = new StreamReader(@"..\..\input.txt"))
        {
            int count = 0;
            string line = inputReder.ReadLine();

            while (line != null)
            {
                count++;

                if (count % 2 != 0)
                {
                    Console.WriteLine("{0} - {1}", count, line);
                }

                line = inputReder.ReadLine();
            }
        }
    }
}
