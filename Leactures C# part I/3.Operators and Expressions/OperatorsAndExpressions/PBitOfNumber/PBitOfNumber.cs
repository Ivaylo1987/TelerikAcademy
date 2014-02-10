using System;

class PBitOfNumber
{
    static void Main()
    {
        int numToCheck = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1;

        int temp = numToCheck;
        Console.WriteLine(Convert.ToString(numToCheck, 2).PadLeft(32, '0')); // additional line for clarity

        mask = mask << p;
        numToCheck = numToCheck & mask;
        numToCheck = numToCheck >> p;

        if (numToCheck == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}