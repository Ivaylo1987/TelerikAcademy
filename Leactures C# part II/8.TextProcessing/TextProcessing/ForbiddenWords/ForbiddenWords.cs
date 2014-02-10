using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    /* We are given a string containing a list of forbidden words and a text containing some of these words.
     * Write a program that replaces the forbidden words with asterisks. 
     */
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string pattern = @"\b(PHP|Microsoft|CLR)\b";

        var result = Regex.Replace(text, pattern, m => new String('*', m.Value.Length));   //lambda expression to get the lenght of each replaced item.

        Console.WriteLine(result);
    }
}
