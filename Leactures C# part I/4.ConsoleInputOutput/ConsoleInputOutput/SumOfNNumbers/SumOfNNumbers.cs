using System;

class SumOfNNumbers
{
    /* Write a program that gets a number n and after that
     * gets more n numbers and calculates and prints their sum. 
     */

    static void Main()
    {
        int sum = 0;

        Console.Write("Please, enter a number: ");
        int numberOfValues = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfValues; i++)
        {
            Console.Write("Please, enter number {0}: ", i);
            int tembNumber = int.Parse(Console.ReadLine());
            sum += tembNumber;
        }
        Console.WriteLine("The sum is {0}.", sum);
    }
}
