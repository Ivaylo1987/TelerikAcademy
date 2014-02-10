using System;

class NumbersInbetween
{
    /* Write a program that reads two positive integer numbers and prints
     * how many numbers p exist between them such that the reminder
     * of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
     */

    static void Main()
    {
        int counter = 0;

        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("Between {0} and {1} you have {2} numbers that devide by 5 with remainder 0.", firstNumber, secondNumber, counter);
    }
}
