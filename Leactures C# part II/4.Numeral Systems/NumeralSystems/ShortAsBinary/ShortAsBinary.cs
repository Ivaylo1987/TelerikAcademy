using System;
using System.Collections.Generic;

class ShortAsBinary
{
    /* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
     */

    static List<int> ConvertToBin(short shortNumber)
    {
        List<int> binaryNumber = new List<int>();   //used List to keep the values.

        while (shortNumber != 0)
        {
            binaryNumber.Add((int)(shortNumber % 2));
            shortNumber /= 2;
        }

        while (binaryNumber.Count != 16)   //add 0 to represent a short number with 16 digits.
        {
            binaryNumber.Add(0);
        }

        //Reverse and return the binary nimber as string.
        binaryNumber.Reverse();

        return binaryNumber;
    }

    static string ConvertShortToBinary(short shortNumber)
    {
        List<int> result = new List<int>();

        if (shortNumber < 0)
        {
            // -n = ~(n - 1) - we use this formula
            shortNumber = (short)((-shortNumber) - 1);   //reverse the sign of the number and subtract 1 according to the formula above
            result = ConvertToBin(shortNumber);

            //reverse the bits according to the formula above and get the result
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            return string.Join("", result);
        }
        else   //if positive number just convert the number.
        {
            result = ConvertToBin(shortNumber);
            return string.Join("", result); 
        }
    }

    
    static void Main()
    {
        short number = -112;
        Console.WriteLine(ConvertShortToBinary(number));
    }
}
