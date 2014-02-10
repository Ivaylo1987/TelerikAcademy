using System;
using System.Text;

class BinToHex
{
    /* Write a program to convert binary numbers to hexadecimal numbers (directly).
     */
    static string ConvertBinToHex(string binNumber)
    {
        StringBuilder hexNumber = new StringBuilder();
        if (binNumber.Length % 4 != 0 )
        {
            int newLenght = binNumber.Length + (4 - (binNumber.Length % 4));
            binNumber = binNumber.PadLeft(newLenght, '0');
        }

        for (int i = 0; i < binNumber.Length; i += 4)
        {
            switch (binNumber.Substring(i, 4))
            {
                case "1010":
                    hexNumber.Append("A");
                    break;
                case "1011":
                    hexNumber.Append("B");
                    break;
                case "1100":
                    hexNumber.Append("C");
                    break;
                case "1101":
                    hexNumber.Append("D");
                    break;
                case "1110":
                    hexNumber.Append("E");
                    break;
                case "1111":
                    hexNumber.Append("F");
                    break;
                case "0000":
                   // hexNumber.Append("0");
                    break;
                case "0001":
                    hexNumber.Append("1");
                    break;
                case "0010":
                    hexNumber.Append("2");
                    break;
                case "0011":
                    hexNumber.Append("3");
                    break;
                case "0100":
                    hexNumber.Append("4");
                    break;
                case "0101":
                    hexNumber.Append("5");
                    break;
                case "0110":
                    hexNumber.Append("6");
                    break;
                case "0111":
                    hexNumber.Append("7");
                    break;
                case "1000":
                    hexNumber.Append("8");
                    break;
                case "1001":
                    hexNumber.Append("9");
                    break;
            }
        }

        return hexNumber.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ConvertBinToHex("00111011101111"));
        Console.WriteLine(ConvertBinToHex("01101"));
        Console.WriteLine(ConvertBinToHex("0101"));
    }
}
