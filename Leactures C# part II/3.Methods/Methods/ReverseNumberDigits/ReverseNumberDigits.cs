using System;

class ReverseNumberDigits
{
    /* Write a method that reverses the digits of given decimal number. Example: 256  652
     */

    static int Reverse(int numberToReverse) 
    {
        char[] arr = Convert.ToString(numberToReverse).ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        return Convert.ToInt32(result);
    }

    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Reverse(number));
    }
}
