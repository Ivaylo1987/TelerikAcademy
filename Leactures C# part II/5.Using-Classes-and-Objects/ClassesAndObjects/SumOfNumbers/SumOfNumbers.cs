using System;

class SumOfNumbers
{
    /* You are given a sequence of positive integer values written into a string, separated by spaces.
     * Write a function that reads these values from given string and calculates their sum. Example:
	 * string = "43 68 9 23 318"  result = 461
     */
    static int SplitAndCals(string inputString)
    {
        int sum = 0;
        var numbers = inputString.Split(' ');

        foreach (var number in numbers)
        {
            sum += Convert.ToInt32(number);
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SplitAndCals("43 68 9 23 318"));   //you can put any space separeted string here.
    }
}
