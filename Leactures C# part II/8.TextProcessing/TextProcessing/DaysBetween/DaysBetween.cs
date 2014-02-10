using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DaysBetween
{
    /* Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
     */

    static DateTime ParseDate()
    {
        Console.Write("Please, enter a date (day.month.year): ");
        string[] seperators = { ".", ". ", ", ", "," };
        var input = Console.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        return new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
    }
    static void Main(string[] args)
    {

        DateTime firstDate = ParseDate();
        DateTime secondDAte = ParseDate();

        Console.WriteLine(Math.Abs((secondDAte - firstDate).Days));
    }
}
