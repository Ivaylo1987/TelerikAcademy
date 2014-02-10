using System;
using System.IO;

class CompareLines
{
    static void Main()
    {
        string lineFromFirst = null;
        string lineFromSecond = null;

        using (StreamReader firstReader = new StreamReader(@"..\..\firstInput.txt"))
        {
            using (StreamReader secondReader = new StreamReader(@"..\..\secondInput.txt"))
            {
                lineFromFirst = firstReader.ReadLine();
                lineFromSecond = secondReader.ReadLine();
                int lines = 0;
                int samelines = 0;

                while (lineFromFirst != null)
                {
                    lines++;
                    if (lineFromFirst == lineFromSecond)
                    {
                        samelines++;
                    }

                    lineFromFirst = firstReader.ReadLine();
                    lineFromSecond = secondReader.ReadLine();
                }

                Console.WriteLine("Same: {0}", samelines);
                Console.WriteLine("Different: {0}", lines - samelines);
            }
        }
    }
}
