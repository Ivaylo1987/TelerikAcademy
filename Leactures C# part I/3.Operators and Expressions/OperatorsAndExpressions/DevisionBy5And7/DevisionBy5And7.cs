using System;

class DevisionBy5And7
{
    static void Main()
    {
        long numToCheck = long.Parse(Console.ReadLine());
        if ((numToCheck % 5 == 0) && (numToCheck % 7 == 0))
        {
            Console.WriteLine("Number {0}, can be divided by 5 and 7. ", numToCheck);
        }
        else
        {
            Console.WriteLine("Number {0}, can NOT be divided by 5 and 7. ", numToCheck);
        }
    }
}
