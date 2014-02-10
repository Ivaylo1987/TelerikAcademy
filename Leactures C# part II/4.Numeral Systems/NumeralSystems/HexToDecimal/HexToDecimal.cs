using System;

class HexToDecimal
{
    /* Write a program to convert hexadecimal numbers to their decimal representation.
     */
    static long ConvertHexToDecimal(string hexNumber) 
    {
        long result = 0;
        int pow = 1;   //this is the power of 16 that is used. MAth.Pow is too slow.
        char currentChar = '\0';

        for (int i = 0; i < hexNumber.Length; i++)
        {
            currentChar = hexNumber[hexNumber.Length - 1 - i];

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
            pow *= 16;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(ConvertHexToDecimal("64"));
        Console.WriteLine(ConvertHexToDecimal("5eB"));
        Console.WriteLine(ConvertHexToDecimal("EAAcffF"));
    }
}
