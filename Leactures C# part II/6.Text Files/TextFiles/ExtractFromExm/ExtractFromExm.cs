using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractFromExm
{
    static void Main()
    {
        using (StreamReader inputRaader = new StreamReader(@"..\..\input.txt"))
        {
            string line = inputRaader.ReadLine();
            string pattern = @"(?<=>)[^<>]+?(?=</)";

            var words = Regex.Matches(line, pattern, RegexOptions.IgnorePatternWhitespace);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
