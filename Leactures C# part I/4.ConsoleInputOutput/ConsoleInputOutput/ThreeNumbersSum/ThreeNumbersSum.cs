using System;

class ThreeNumbersSum
{
    /*  Write a program that reads 3 integer numbers from the console and prints their sum.
     */
    static void Main()
    {
        int sum = 0;
        int number = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Please, enter number {0}: ", i);
            number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Sum is {0}.", sum);
    }
}
