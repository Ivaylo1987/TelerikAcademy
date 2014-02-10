using System;

class PrintNNumbers
{
    //Write a program that prints all the numbers from 1 to N.

    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
