using System;

class OddOrEven
{
    static void Main()
    {
        long numToCheck = long.Parse(Console.ReadLine());

        if (numToCheck % 2 == 0)
        {
            Console.WriteLine("Number {0} is {1}.", numToCheck, "even");
        }
        else
        {
            Console.WriteLine("Number {0} is {1}.", numToCheck, "odd");
        }
        

    }
}
