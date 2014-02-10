using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Palindromes
{
    /* Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
     */

    //check if the word is a polindrome.
    static bool isPolindrome(string input)
    {
        bool itIsPolindrome = true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                itIsPolindrome = false;
            }
        }
        return itIsPolindrome;
    }
    static void Main()
    {
        string text = @"ABBA, lamal exe, Test, Void{} xhex, chllhc";
        string pattern = @"\b\w+\b";

        var words = Regex.Matches(text, pattern);

        foreach (Match word in words)
        {
            if (isPolindrome(word.Value))
            {
                Console.WriteLine(word.Value);
            }
        }
    }
}
