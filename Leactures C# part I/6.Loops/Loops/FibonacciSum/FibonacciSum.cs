using System;

class FibonacciSum
{
    static void Main()
    {
         /*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
          * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
          */
        Console.Write("Please, enter N: ");
        int n = int.Parse(Console.ReadLine());

        int fNum = 0;
        int sNum = 1;
        int sum = 0;

        switch (n)
        {
            case 0:
            case 1:
                break;
            case 2:
                sum = sNum;
                break;
            default:
                sum += sNum;
                for (int i = 0; i < n - 2; i++)
                {
                    sNum = fNum + sNum;
                    fNum = sNum - fNum;
                    sum += sNum;
                }
                break;
        }
        Console.Write(sum + " ");
        Console.WriteLine();
    }
}
