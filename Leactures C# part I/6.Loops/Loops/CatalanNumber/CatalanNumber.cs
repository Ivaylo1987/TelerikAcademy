using System;

class CatalanNumber
{
    static decimal CalcFactorial(int n)
    {
        decimal factorial = 1;
        for (int i = n; i >= 2; i--)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        Console.Write("Please, enter N: ");
        int n = int.Parse(Console.ReadLine());

        decimal catalanNum = 0;
        catalanNum = CalcFactorial(2 * n) / (CalcFactorial(n + 1) * CalcFactorial(n));

        Console.WriteLine(catalanNum);
    }
}


function F(n){for(var i=2,s=1;i<=n;i++)s*=(4*i-2)/(1+i);return s/2;}