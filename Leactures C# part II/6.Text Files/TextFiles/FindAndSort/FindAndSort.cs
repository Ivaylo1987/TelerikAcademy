using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class FindAndSort
{
    static void Main()
    {
        using (StreamReader wordsReader = new StreamReader(@"..\..\words.txt"))
        {
            Dictionary<string, int> wordAndCount = new Dictionary<string, int>();

            //read text and find in it only words.
            string text = wordsReader.ReadToEnd();
            var words = Regex.Matches(text, @"\b\w+\b", RegexOptions.IgnorePatternWhitespace);

            using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
            {
                string lines = inputReader.ReadToEnd();   //all text in the input File

                for (int i = 0; i < words.Count; i++)   //check the count of every word and put them in a dictionary
                {
                    wordAndCount.Add(words[i].Value, Regex.Matches(lines, (@"\b" + words[i].Value + @"\b")).Count);
                }
            }

            var sortedPairs = wordAndCount.OrderByDescending(x => x.Value);   //sort with linq

            StreamWriter outPut = new StreamWriter(@"..\..\output.txt");

            foreach (var item in sortedPairs)
            {
                outPut.WriteLine();
                Console.WriteLine("{0} - {1}", item.Value, item.Key);
            }

            outPut.Dispose();
        }
    }
}
