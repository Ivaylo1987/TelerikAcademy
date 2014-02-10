using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReverseASentence
{
    /* Write a program that reverses the words in given sentence.
     * "C# is not C++, not PHP and not Delphi!"
     * "Delphi not and PHP, not C++ not is C#!".
     */
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string pattern = @"\s+|,\s*|!\s*|\.\s*";
        
        List<string> result = new List<string>();
        List<string> wordsList = new List<string>();

        var words = Regex.Split(text, pattern);
        var separators = Regex.Matches(text, pattern);

        foreach (var item in words)
        {
            if (item != string.Empty)
            {
                wordsList.Add(item);
            }
        }

        int lastIndex = Math.Max(wordsList.Count, separators.Count);

        for (int i = 0; i < lastIndex; i++)
        {
            if (wordsList[wordsList.Count - i - 1] != string.Empty && (wordsList.Count - i - 1 >= 0))
            {
                result.Add(wordsList[wordsList.Count - i - 1]);

                if (i <= separators.Count - 1)
                {
                    result.Add(separators[i].Value);
                }
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}
