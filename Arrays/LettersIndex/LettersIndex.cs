using System;
using System.Collections.Generic;

class LettersIndex
{
    /* Write a program that creates an array containing all letters from the alphabet (A-Z).
     * Read a word from the console and print the index of each of its letters in the array.
     */
    static void Main()
    {
        int index;
        List<int> lettersArray = new List<int>();

        //Initialize array
        for (char i = 'A'; i <= 'Z'; i++)
        {
            lettersArray.Add(i);
        }
        
        Console.Write("Please, enter a word: ");
        string imputWord = Console.ReadLine().ToUpperInvariant();  //Take the string always as UPPERCASE.

        //Find Index and Print
        foreach (var letter in imputWord)
        {
            index = lettersArray.IndexOf(letter);
            Console.Write("{0} ", index);
        }
        Console.WriteLine();
    }
}