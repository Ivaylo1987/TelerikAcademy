using System;

class BitThree
{
    static void Main()
    {
        int numToCheck = int.Parse(Console.ReadLine());
        int mask = 1;

        Console.WriteLine(Convert.ToString(numToCheck, 2).PadLeft(32, '0')); // additional line for clarity

        mask = mask << 3;
        numToCheck = numToCheck & mask;
        numToCheck = numToCheck >> 3;

        Console.WriteLine("Third bit is {0} ", numToCheck);
    }
}
