using System;

class FactorialNK
{
    static void Main()
    {
        //Write a program that calculates N!/K! for given N and K (1<K<N).

        Console.Write("Please, enter K: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Please, enter N where (N > K): ");
        int n = int.Parse(Console.ReadLine());

        // N!/K! = (K + 1).(k + 2)...(N -1)N.
        int factorialNonK = 1;
        for (int i = n; i >= k + 1; i--)
        {
            factorialNonK *= i; 
        }

        Console.WriteLine(factorialNonK);
    }
}
