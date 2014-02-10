using System;

class LeapYear
{
    /* Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
     */

    static void Main()
    {
        Console.Write("Please, enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Is {0} leap - {1}!", year,isLeap);
    }
}
