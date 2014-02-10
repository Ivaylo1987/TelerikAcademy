using System;
using System.Collections.Generic;
using System.Numerics;

class AddNumbersAsArrays
{
    /* Write a method that adds two positive integer numbers represented as arrays of digits
     * (each array element arr[i] contains a digit;
     * the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
     */

    //Method to convert large string numbers into int arrays.
    static List<int> ConvertToIntList(string numberAsString) 
    {
        List<int> numberAsIntArray = new List<int>();
        for (int i = 0; i < numberAsString.Length; i++)
        {
            numberAsIntArray.Add(numberAsString[(numberAsString.Length - 1) - i] - '0');
        }

        return numberAsIntArray;
    }

    //Method to sum two ints as arrays.
    static List<int> SumOfNumbersAsArrays(List<int> firstNumber, List<int> secondNumber)
    {
        List<int> firstNumberAsArray = new List<int>(firstNumber);
        List<int> secondNumberAsArray = new List<int>(secondNumber);
        List<int> temp = new List<int>();

        int greaterCount = Math.Max(firstNumberAsArray.Count, secondNumberAsArray.Count);
        int remainder = 0;

        //Make the count of the arrays equal
        if (firstNumberAsArray.Count < greaterCount)
        {
            for (int i = firstNumberAsArray.Count; i < greaterCount; i++)
            {
                firstNumberAsArray.Add(0);
            }
        }
        else if (secondNumberAsArray.Count < greaterCount)
        {
            for (int i = secondNumberAsArray.Count; i < greaterCount; i++)
            {
                secondNumberAsArray.Add(0);
            }
        }

        //Sum the two arrays
        for (int i = 0; i < greaterCount; i++)
        {
            temp.Add((firstNumberAsArray[i] + secondNumberAsArray[i] + remainder) % 10);
            remainder = (firstNumberAsArray[i] + secondNumberAsArray[i] + remainder) / 10;
        }
        if (remainder > 0)
        {
            temp.Add(remainder);
        }

        temp.Reverse();

        return temp;
    }

    static void Main()
    {
        string numberOne = "122345";
        string numberTwo = "1";

        List<int> result = SumOfNumbersAsArrays(ConvertToIntList(numberOne), ConvertToIntList(numberTwo));

        Console.WriteLine(String.Join("", result));

    }
}