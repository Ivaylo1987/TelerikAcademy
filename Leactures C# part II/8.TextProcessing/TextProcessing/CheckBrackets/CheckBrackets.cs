using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBrackets
{
    static bool AreBracketsCorrect(string strToCheck)
    {

       int  numberOfBrackets = 0;

        for (int i = 0; i < strToCheck.Length; i++)
        {
            if (strToCheck[i] == '(')
            {
                numberOfBrackets++; 
            }
            if (strToCheck[i] == ')')
            {
                numberOfBrackets--;
            }
        }

        bool result = numberOfBrackets == 0;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(AreBracketsCorrect(Console.ReadLine()));
    }
}
