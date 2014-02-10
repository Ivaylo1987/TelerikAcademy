using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WordsInAlphabeticalOrder
{
    /* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
     */
    static void Main()
    {
        string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";
        string pattern = @"\b\w+\b";

        var words = Regex.Matches(text, pattern);
        List<string> result = new List<string>();

        foreach (Match item in words)
        {
            result.Add(item.Value);
        }

        result.Sort();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
