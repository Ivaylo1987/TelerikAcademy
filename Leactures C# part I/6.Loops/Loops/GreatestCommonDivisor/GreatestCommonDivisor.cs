using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Please, enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Please, enter b: ");
        int b = int.Parse(Console.ReadLine());

        int remainder = 0;

        if ((a == 0) || (b == 0))
        {
            Console.WriteLine("GCD is {0}", 0);
        }
        else if (a % b == 0)
        {
            Console.WriteLine("Greatest comon divisor is {0}", b);
        }
        else //Euclidean Algorithm
        {
            while (a % b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            Console.WriteLine("GCD is {0}", b);
        }
    }
}