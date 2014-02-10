using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SubStringNumber
{
    /* Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
     */

    static int CheckOccurences(string strToCheck, string key)
    {
        return Regex.Matches(strToCheck, key, RegexOptions.IgnoreCase).Count;
    }

    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight.
So we are drinking all the day.
We will move out of it in 5 days.";
        string key = "in";

        Console.WriteLine(CheckOccurences(text, key));
    }
}
