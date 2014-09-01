namespace PrefixTreeDemo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class EntryPoint
    {
        public static void Main()
        {
            var filePath = @"..\..\text.txt";
            var prefixTree = new Trie();
            var count = 0;

            // populate prefix tree
            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var words = Regex.Matches(line, @"\b\w+\b");

                    foreach (Match word in words)
                    {
                        prefixTree.AddWord(word.Value);
                        count++;
                    }

                    line = reader.ReadLine();
                }

                // Search in the tree
                string[] wordsToSearch = new string[] { "Lorem", "ipsum", "dolor" };

                foreach (var word in wordsToSearch)
                {
                    if (prefixTree.WordExists(word))
                    {
                        Console.WriteLine("{0} exists with count {1}", word, prefixTree.GetWordOccurrenceCount(word));
                    }
                }

                Console.WriteLine("Total word count: {0}", count);
            }
        }
           
    }
}
