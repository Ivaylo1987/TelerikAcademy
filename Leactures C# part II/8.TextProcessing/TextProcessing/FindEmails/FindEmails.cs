using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class FindEmails
{
    /* Write a program for extracting all email addresses from given text.
     * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
     */
    static void Main()
    {
        string text = @"Pesho.Hristov.Georgiev@gmail.test.papur.com, daljfagf bla bla text bulshit.... gosho, Geshev@abv.bg.
petar.hristov@avb.sektir.bg";
        string pattern = @"([\w][\w\-\.]{0,49})@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+)([a-zA-Z]{2,4})";

        var emails = Regex.Matches(text, pattern);

        foreach (Match mail in emails)
        {
            Console.WriteLine(mail.Value);
        }
    }
}
