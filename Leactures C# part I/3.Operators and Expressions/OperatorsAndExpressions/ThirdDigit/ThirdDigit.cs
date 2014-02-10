using System;

class ThirdDigit
{
    static void Main()
    {
        int numToCheck = int.Parse(Console.ReadLine());

        bool result = ((numToCheck / 100) % 10) == 7;

        Console.WriteLine(result);
    }
}
