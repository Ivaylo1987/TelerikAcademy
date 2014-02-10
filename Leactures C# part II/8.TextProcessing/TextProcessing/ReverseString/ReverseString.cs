using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    /* Write a program that reads a string, reverses it and prints the result at the console.
     * Example: "sample"  "elpmas".
     */
    static string Reverse(string strToReverse)
    {
        char[] arr = strToReverse.ToCharArray();
        Array.Reverse(arr);

        return new string(arr);
    }

    static void Main()
    {
        Console.Write("Enter a string to reverse: ");
        Console.WriteLine(Reverse(Console.ReadLine()));
    }
}
