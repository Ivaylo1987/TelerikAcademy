using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CharToUnicode
{
    /* Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
     */
    static void Main()
    {
        string text = "Hi! C# homework. :)";

        foreach (var letter in text)
        {
            Console.Write("\\u{0:X4}", (int)letter);
        }
        Console.WriteLine();
    }
}
