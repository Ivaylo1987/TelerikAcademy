using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static string ConvertDecimalToBinary(long decimalNum) 
    {
        List<int> binaryNumber = new List<int>();   //We used List to keep the values.

        while (decimalNum != 0)
        {
            binaryNumber.Add((int)(decimalNum % 2));
            decimalNum /= 2;
        }

        //Reverse and return the binary nimber as string.
        binaryNumber.Reverse();
        return string.Join("", binaryNumber);
    }

    static void Main()
    {
        /* Write a program to convert decimal numbers to their binary representation.
         */
        Console.WriteLine(ConvertDecimalToBinary(10));
        Console.WriteLine(ConvertDecimalToBinary(2350345232985));
        Console.WriteLine(ConvertDecimalToBinary(128));
    }
}
