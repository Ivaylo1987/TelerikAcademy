using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class ParseDate
{
    /*Write a program that reads a date and time given in the format:
     * day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format)
     * along with the day of week in Bulgarian.
     */
    static void Main(string[] args)
    {
        Console.Write("Please, enter a date (day.month.year): ");
        string[] seperators = { ".", ". ", ", ", ",", ":", ": ", " "};
        var input = Console.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        DateTime dateAfter = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]), int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5])).AddHours(6).AddMinutes(30);

        Console.WriteLine("{0} - {1}", dateAfter, dateAfter.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
