using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    /* A dictionary is stored as a sequence of text lines containing words and their explanations.
     * Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
     */
    static void PrintDefinition(string inputWord)
    {
        Dictionary<string, string> wordsDictionary = new Dictionary<string, string>();

        //Could be a loop doing it.
        wordsDictionary.Add(".NET", "platform for applications from Microsoft");
        wordsDictionary.Add("CLR", @"managed execution environment for .NET namespace – hierarchical organization of classes");

        Console.WriteLine("{0} - {1}", inputWord, wordsDictionary[inputWord]);
    }

    static void Main()
    {

        Console.Write("Please, enter a word: ");

        PrintDefinition(Console.ReadLine().ToUpper());
    }
}
