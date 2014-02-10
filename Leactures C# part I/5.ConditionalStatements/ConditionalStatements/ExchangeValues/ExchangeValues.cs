using System;

class ExchangeValues
{
    /* Write an if statement that examines two integer variables and exchanges their values
     * if the first one is greater than the second one.
     */

    static void Main()
    {
        Console.Write("Please, enter first value: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second value: ");
        int secondValue = int.Parse(Console.ReadLine());

        //swap values without a third variable.
        if (firstValue > secondValue)
        {
            secondValue = secondValue + firstValue;
            firstValue = secondValue - firstValue;
            secondValue = secondValue - firstValue;
        }

        Console.WriteLine("First value is {0}", firstValue);
        Console.WriteLine("Second value is {0}", secondValue);
    }
}
