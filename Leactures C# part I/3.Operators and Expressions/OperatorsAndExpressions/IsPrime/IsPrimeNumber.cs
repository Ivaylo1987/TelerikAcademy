using System;

class IsPrimeNumber
{
    static void Main()
    {
        int numToCheck = int.Parse(Console.ReadLine());

        bool isPrime = true;
        for (int i = 2; i < Math.Sqrt(numToCheck); i++)
        {
            if (numToCheck % i == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Number {0} is Prime. ", numToCheck);
        }
        else
        {
            Console.WriteLine("Number {0} is NOT Prime. ", numToCheck);
        }
    }
}
