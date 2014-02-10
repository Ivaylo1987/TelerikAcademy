using System;

class ExchangeThreeBits
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int numToChange = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(numToChange, 2).PadLeft(32, '0'));
        
        int firstBitPosition = 3;
        int secondBitPosition = 24;
        int firstBitToSwap = 0;
        int secondBitToSwap = 0;
        int mask = 1;

        for (int i = 0; i < 3; i++)
        {
            firstBitToSwap = numToChange & (mask << firstBitPosition);
            firstBitToSwap >>= firstBitPosition;
            secondBitToSwap = numToChange & (mask << secondBitPosition);
            secondBitToSwap >>= secondBitPosition;

            if (firstBitToSwap == secondBitToSwap)
            {
                Console.WriteLine("Bits {0} and bit {1} are identical. No need to swap. ", firstBitPosition, secondBitPosition);
            }
            else if (firstBitToSwap > secondBitToSwap)
            {
                numToChange = numToChange & (~(mask << firstBitPosition));
                numToChange = numToChange | (mask << secondBitPosition);
            }
            else
            {
                numToChange = numToChange | (mask << firstBitPosition);
                numToChange = numToChange & (~(mask << secondBitPosition));
            }
            firstBitPosition++;
            secondBitPosition++;
        }
        Console.WriteLine(Convert.ToString(numToChange, 2).PadLeft(32, '0'));
    }
}