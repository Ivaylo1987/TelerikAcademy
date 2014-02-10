using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractingDates
{
    /* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
     * Display them in the standard date format for Canada.
     */
    static void Main()
    {
        string text = "asd12.10.201431333sdad 13.12.2014, 01.1.1987, 01.01.2000.";
        string pattern = @"\b(\d{2}).(\d{2}).(\d{4})\b";

        var dates = Regex.Matches(text, pattern);

        foreach (Match date in dates)
        {
            DateTime result = new DateTime(int.Parse(date.Groups[3].Value), int.Parse(date.Groups[2].Value), int.Parse(date.Groups[1].Value));

            Console.WriteLine(result.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}
