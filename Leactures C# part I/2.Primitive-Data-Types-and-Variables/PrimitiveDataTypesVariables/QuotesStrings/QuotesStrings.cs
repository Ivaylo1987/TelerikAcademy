using System;

class QuotesStrings
{
    /*Declare two string variables and assign them with following value:
     * Do the above in two different ways: with and without using quoted strings.
     */
    static void Main()
    {
        string escString = "The \"use\" of quotations causes difficulties.";
        string quotString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotString);
        Console.WriteLine(escString);
    }
}
