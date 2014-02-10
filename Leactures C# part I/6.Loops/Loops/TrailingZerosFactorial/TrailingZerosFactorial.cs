using System;

class TrailingZerosFactorial
{
    static void Main()
    {
        /* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
        * N = 10  N! = 3628800  2
        * N = 20  N! = 2432902008176640000  4
        * Does your program work for N = 50 000?
        * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
        */

        Console.Write("Please enter N for the Factorial: ");
        int n = int.Parse(Console.ReadLine());

        int divisor = 5;
        int numberOFZeros = 0;
        int numberOfMultiples = int.MinValue;

        while (numberOfMultiples != 0)
        {
            numberOfMultiples = n / divisor;    //for every divisor 5, 25, 125... check number of multiple in N.
            numberOFZeros += numberOfMultiples;
            divisor *= divisor;
        }

        Console.WriteLine("Number of trailing zeros in {0} factorial is {1}", n, numberOFZeros);

    }
}
