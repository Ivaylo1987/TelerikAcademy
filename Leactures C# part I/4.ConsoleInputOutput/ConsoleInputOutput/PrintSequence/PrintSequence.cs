using System;

class PrintSequence
{
    /* Write a program that reads an integer number n from the console 
     * and prints all the numbers in the interval [1..n], each on a single line.
     */

    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int finalNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= finalNumber; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
