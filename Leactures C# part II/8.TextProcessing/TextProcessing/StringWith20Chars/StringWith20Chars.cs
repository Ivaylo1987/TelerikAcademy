using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringWith20Chars
{
    /* Write a program that reads from the console a string of maximum 20 characters.
     * If the length of the string is less than 20, the rest of the characters should be filled with '*'.
     * Print the result string into the console.
     */

    static void Main()
    {
        string input = Console.ReadLine();
        string result = null;

        if (input.Length < 20)
        {
            result = input.PadRight(20, '*');
        }
        else
        {
            result = input.Substring(0, 20);
        }

        Console.WriteLine(result);
    }
}
