namespace WordsInFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    class Demo
    {
        static void Main()
        {
            var filePath = @"..\..\words.txt";
            var wordsAndCounts = new Dictionary<string, int>();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var words = Regex.Matches(line, @"\b\w+\b");

                    foreach (Match word in words)
                    {
                        if (!wordsAndCounts.ContainsKey(word.Value.ToLower()))
                        {
                            wordsAndCounts.Add(word.Value.ToLower(), 0);
                        }

                        wordsAndCounts[word.Value.ToLower()]++;
                    }

                    line = reader.ReadLine();
                }

                foreach (var word in wordsAndCounts)
                {
                    Console.WriteLine("{0} -> {1}", word.Key, word.Value);
                }
            }

        }
    }
}
