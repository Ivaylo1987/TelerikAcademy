using System;

class WorkDays
{
    /* Write a method that calculates the number of workdays between today and given date, passed as parameter.
     * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
     */

    static int CalcWorkDays(DateTime endDAte)
    {
        DateTime[] daysOff = 
        {
            new DateTime(2014, 3, 3),
            new DateTime(2014, 4, 18),
            new DateTime(2014, 5, 1),
            new DateTime(2014, 5, 6),
            new DateTime(2014, 9, 6),
            new DateTime(2014, 12, 24)
        };

        DateTime toDay = DateTime.Today;

        int totalNumberofAlldays = endDAte.Subtract(toDay).Days;

        //If a day is day-off ot weekedn subtract one.
        for (DateTime i = toDay; i < endDAte;  i = i.AddDays(1))
        {
            if ((i.DayOfWeek == DayOfWeek.Saturday) || (i.DayOfWeek == DayOfWeek.Sunday))
            {
                totalNumberofAlldays--;
            }
            else
            {
                for (int j = 0; j < daysOff.Length; j++)
                {
                    if (i == daysOff[j])
                    {
                        totalNumberofAlldays--;
                    }
                }
            }
        }

        return totalNumberofAlldays;
    }

    static void Main()
    {
        Console.Write("Enter date: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        DateTime endDate = new DateTime(year, month, day);
        Console.WriteLine(CalcWorkDays(endDate));
    }
}
