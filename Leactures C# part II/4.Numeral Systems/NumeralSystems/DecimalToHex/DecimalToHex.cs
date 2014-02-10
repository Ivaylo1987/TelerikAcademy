using System;
using System.Collections.Generic;

class DecimalToHex
{
    /* Write a program to convert decimal numbers to their hexadecimal representation.
     */

    static string ConvertDecimalToHex(long numberToConvert) 
    {
        List<char> hexNumber = new List<char>();   //hex number as array of chars.
        int currentRemainder = 0;

        while (numberToConvert != 0)
        {
            currentRemainder = (int)(numberToConvert % 16);

            if (currentRemainder <= 9)   // If less than 9 add the numeric representation to the char array
            {
                hexNumber.Add((char)('0' + currentRemainder));
            }
            else   //else ad the letter char to the array
            {
                hexNumber.Add((char)('A' + currentRemainder - 10));
            }

            numberToConvert /= 16;
        }

        //Reverse and print
        hexNumber.Reverse();
        return string.Join("", hexNumber);
    }

    static void Main()
    {
        Console.WriteLine(ConvertDecimalToHex(15));
        Console.WriteLine(ConvertDecimalToHex(111));
        Console.WriteLine(ConvertDecimalToHex(16));
        Console.WriteLine(ConvertDecimalToHex(1515));
    }
}
