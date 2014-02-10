using System;
using System.IO;
using System.Text;

class RemoveOddLines
{
    static void Main()
    {
        using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
            {
                StringBuilder oddLines = new StringBuilder();
                string line = inputReader.ReadLine();
                int counter = 1;

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        oddLines.AppendLine(line);
                    }

                    line = inputReader.ReadLine();
                    counter++;
                }

                outputWriter.WriteLine(oddLines.ToString());
                Console.WriteLine("Done!");
            }
        }
    }
}
