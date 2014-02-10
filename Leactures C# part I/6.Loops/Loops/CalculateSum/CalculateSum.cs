using System;

class CalculateSum
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        Console.Write("Please, enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter X: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal factorialN = 1;
        decimal multipleX = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            multipleX *= x;
            sum += factorialN / multipleX;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
