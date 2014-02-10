using System;

class ComplexFactorialNK
{
    /* Write a program that calculates N!*K!/(K-N)! for given N and K (1<N<K).
         *   N!*K! / (K-N)! =
         *   N!* (K!/(K-N)!) =
         *   N!* (...(K-N+1)(K-2)(K-1)K) защото K > N.
         */

    static decimal CalcFactorialN(int num) 
    {
        int factorial = 1;
        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static decimal CalcFactorialKN(int k, int n)
    {
        decimal factorial = 1;
        for (int i = k; i >= (k - n + 1); i--)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {

        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter K where K > N: ");
        int k = int.Parse(Console.ReadLine());

        // two methods are used for code clarity.
        decimal result = CalcFactorialKN(k, n) * CalcFactorialN(n);

        Console.WriteLine(result);
    }

    
}
