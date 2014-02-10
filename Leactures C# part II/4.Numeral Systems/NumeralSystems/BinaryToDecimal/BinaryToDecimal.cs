using System;

class BinaryToDecimal
{
    /* Write a program to convert binary numbers to their decimal representation.
     */

    static long ConvertBinaryToDecimal(string binaryNumber) 
    {
        long result = 0;
        int pow = 1;   //I do not use Math.Pow because it is very slow. This is the power of 2 that is used.

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            result += Convert.ToInt32(binaryNumber[binaryNumber.Length - 1 - i].ToString()) * pow;
            pow *= 2;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(ConvertBinaryToDecimal("10"));
        Console.WriteLine(ConvertBinaryToDecimal("101"));
        Console.WriteLine(ConvertBinaryToDecimal("101011001"));
    }
}