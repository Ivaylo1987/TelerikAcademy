using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        string text = "zelka, papurec, kofa, zelka, bira, skara, zelka, zelka, skara";
        string patternt = @"\b\w+\b";

        var words = Regex.Matches(text, patternt);

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        foreach (Match word in words)
        {
            if (wordsCount.ContainsKey(word.Value))
            {
                wordsCount[word.Value]++;
            }
            else
            {
                wordsCount.Add(word.Value, 1);
            }
        }

        foreach (var item in wordsCount)
        {
            Console.WriteLine("{0} - {1} times", item.Key, item.Value);
        }
    }
}
