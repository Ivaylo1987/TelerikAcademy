using System;

class SwapAnySequenceOfBits
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int numToChange = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(numToChange, 2).PadLeft(32, '0'));
        
        Console.Write("Please, enter the start position on the First sequnce: ");
        int firstBitPosition = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the sequence length: ");
        int SequnceLength = int.Parse(Console.ReadLine());

        Console.Write("Please, enter the start position on the Second sequnce: ");
        int secondBitPosition = int.Parse(Console.ReadLine());

        int firstBitToSwap = 0;
        int secondBitToSwap = 0;
        int mask = 1;

        for (int i = 0; i < SequnceLength; i++)
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
        Console.WriteLine("The result is: {0} -> {1}", numToChange, Convert.ToString(numToChange, 2).PadLeft(32, '0'));
    }
}
