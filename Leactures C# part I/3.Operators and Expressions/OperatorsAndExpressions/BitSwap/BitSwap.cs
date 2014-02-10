using System;

class BitSwap
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int numToChange = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(numToChange, 2).PadLeft(32, '0'));

        Console.WriteLine("Please, enter a position to set: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter value for insert 1/0: ");
        int v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            int mask = 1 << p;
            int numOrMask = numToChange | mask;
            Console.WriteLine(Convert.ToString(numOrMask, 2).PadLeft(32, '0'));
        }
        else if (v == 0)
        {
            int mask = ~(1 << p);
            int numAndMask = numToChange & mask;
            Console.WriteLine(Convert.ToString(numAndMask, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("Конфетиии - пробвай пак!");
        }
    }
}
