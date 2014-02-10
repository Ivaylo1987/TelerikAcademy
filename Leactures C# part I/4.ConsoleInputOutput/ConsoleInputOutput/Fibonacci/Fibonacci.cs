using System;
using System.Numerics;

class Fibonacci
{
    //Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
    static void Main()
    {
        
        BigInteger fNum = 0; // BigInteger is needed
        BigInteger sNum = 1;

        Console.WriteLine(fNum);
        Console.WriteLine(sNum);
        for (int i = 0; i <= 97; i++)
        {
            sNum = sNum + fNum; //  sNum = 2 + 1 = 3
            Console.WriteLine(sNum);
            fNum = sNum - fNum; // fNum = 3 - 1 = 2
        }
    }
}
