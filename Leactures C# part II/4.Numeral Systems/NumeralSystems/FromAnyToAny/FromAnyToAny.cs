using System;
using System.Collections.Generic;

class FromAnyToAny
{
    // Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

    //Th idea is to convert from Any to Decimal and after that from decimal to Any
    static long ConvertFormAnyToDecimal(string numberToConvert, int numeralSystemBase) 
    {
        long result = 0;
        int pow = 1;   //The power to multiply with. 
        char currentChar = '\0';

        for (int i = 0; i < numberToConvert.Length; i++)
        {
            currentChar = numberToConvert[numberToConvert.Length - 1 - i];

            if (char.IsDigit(currentChar))   //If a digit just convert it to int and use it.
            {
                result += Convert.ToInt32(currentChar.ToString()) * pow;
            }
            else   //else convert to its numeral value and then use it.
            {
                currentChar = char.ToUpper(currentChar);   //Convert to upper case before use.
                currentChar -= 'A';
                result += (currentChar + 10) * pow;
            }
            pow *= numeralSystemBase;
        }

        return result;
    }

    static string ConvertFromDecToAny(long decNumber, int baseToConvertTo) 
    {
        List<char> result = new List<char>();
        int currentRemainder = 0;

        while (decNumber != 0)
        {
            currentRemainder = (int)(decNumber % baseToConvertTo);   //the current digit of the converted number

            if (currentRemainder <= 9)
            {
                result.Add((char)('0' + currentRemainder));   //If numeric value convert to the right char and add it to result.
            }
            else   //else find the non-numeric digit and add it to the result.
            {
                result.Add((char)('A' + currentRemainder - 10));
            }

            decNumber /= baseToConvertTo;
        }

        result.Reverse();

        return string.Join("", result);
    }

    static void Main()
    {
        Console.Write("Plese, enter a base of a numeral system: ");
        int baseOfNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter a number in this numeral system: ");
        string number = Console.ReadLine();

        Console.Write("Please, enter a base to convert to: 2 <= base <= 16: ");
        int baseToConvertTo = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertFromDecToAny(ConvertFormAnyToDecimal(number, baseOfNumber), baseToConvertTo));
    }
}
