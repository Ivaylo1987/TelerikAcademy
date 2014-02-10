using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceTag
{
    /* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
     * The tags cannot be nested. Example:
     */
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string pattern = "<upcase>(?<words>.+?)</upcase>";

        Console.WriteLine(Regex.Replace(text, pattern, x => x.Groups["words"].Value.ToUpper()));   //using lambda expression and match group called "words".
    }
}