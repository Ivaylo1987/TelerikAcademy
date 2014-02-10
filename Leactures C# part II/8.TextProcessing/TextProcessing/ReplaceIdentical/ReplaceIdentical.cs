using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceIdentical
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        string pattern = @"([a-z])\1+";

        var result = Regex.Replace(text, pattern, "$1");

        Console.WriteLine(result);
    }
}
