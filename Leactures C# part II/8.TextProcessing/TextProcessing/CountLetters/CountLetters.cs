using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountLetters
{
    static void Main()
    {
        string text = "papurec, kofa, zelka, bira, skara";

        Dictionary<char, int> lettersCount = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (lettersCount.ContainsKey(text[i]) && text[i] != ' ')
            {
                lettersCount[text[i]]++;
            }
            else if (text[i] != ' ')
            {
                lettersCount.Add(text[i], 1);
            }
        }

        //uncomment for sorted.
        //var result = from pair in lettersCount
        //             orderby pair.Value descending
        //             select pair;

        foreach (var item in lettersCount)
        {
            Console.WriteLine("{0} - {1} times", item.Key, item.Value);
        }
    }
}
