using System;
using System.Text;

class HexToBin
{    /* Write a program to convert hexadecimal numbers to binary numbers (directly).
      */
    static string ConvertHexToBin(string hexNumber)
    {
        StringBuilder binNumber = new StringBuilder();

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case 'A':
                    binNumber.Append("1010");
                    break;
                case 'B':
                    binNumber.Append("1011");
                    break;
                case 'C':
                    binNumber.Append("1100");
                    break;
                case 'D':
                    binNumber.Append("1101");
                    break;
                case 'E':
                    binNumber.Append("1110");
                    break;
                case 'F':
                    binNumber.Append("1111");
                    break;
                case '0':
                    binNumber.Append("0000");
                    break;
                case '1':
                    binNumber.Append("0001");
                    break;
                case '2':
                    binNumber.Append("0010");
                    break;
                case '3':
                    binNumber.Append("0011");
                    break;
                case '4':
                    binNumber.Append("0100");
                    break;
                case '5':
                    binNumber.Append("0101");
                    break;
                case '6':
                    binNumber.Append("0110");
                    break;
                case '7':
                    binNumber.Append("0111");
                    break;
                case '8':
                    binNumber.Append("1000");
                    break;
                case '9':
                    binNumber.Append("1001");
                    break;
            }
        }
        return binNumber.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ConvertHexToBin("B5"));
        Console.WriteLine(ConvertHexToBin("AB4"));
        Console.WriteLine(ConvertHexToBin("100"));
    }
}
