using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class StringXOR
{
    /* Write a program that encodes and decodes a string using given encryption key (cipher).
     * The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
     * of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
     */
    static string Encrypt(string input, string key)
    {
        StringBuilder result = new StringBuilder();

        int index = 0;

        foreach (var letter in input)
        {
            if (index >= key.Length)
            {
                index -= key.Length;
            }
            result.Append((char)(letter ^ key[index]));

            index++;
        }

        return result.ToString();
    }

    static void Main()
    {
        string result = Encrypt( "password", "abc");
        Console.WriteLine(result);

        string decripted = Encrypt(result, "abc");
        Console.WriteLine(decripted);
    }

   
}
