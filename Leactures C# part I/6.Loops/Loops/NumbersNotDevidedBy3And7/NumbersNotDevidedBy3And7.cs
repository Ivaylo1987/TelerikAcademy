using System;

class NumbersNotDevidedBy3And7
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

        Console.Write("Please, enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int count=0; //optional for reference

        for (int i = 1; i <= num; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                count++;
                continue;
            }
            Console.Write(i + " ");
        }
        Console.WriteLine("Count {0}", count); // optional for reference
    }
}
