using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumberFormating
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string result = string.Format("{0}, {0:X}, {0:P}, {0:E}", input);

        Console.WriteLine("{0,15}", result);
    }
}
