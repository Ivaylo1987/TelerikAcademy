using System;
using System.Collections.Generic;

class MultiplyArrays
{
    /* Write a program to calculate n! for each n in the range [1..100].
     * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
     */

    //Method to sum two ints as arrays. See Problem 8. - AddNumbersAsArrays

    static int[] ConvertToIntArray(string numberAsString)
    {
        int[] numberAsIntArray = new int[numberAsString.Length];
        for (int i = 0; i < numberAsString.Length; i++)
        {
            numberAsIntArray[i] = (numberAsString[(numberAsString.Length - 1) - i] - '0');
        }

        return numberAsIntArray;
    }

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
        return temp;
    }

    //Method that multiplies two numbers represented as arrays.
    static string MultiplyTwoArrays(int[] firstArr, int[] secondArr) 
    {
        List<int> tempNumber = new List<int>();
        List<int> result = new List<int>();
        result.Add(0);
        int remainder = 0;   //remainder is what "One on mind" is when you multiply.

        for (int i = 0; i < secondArr.Length; i++)
        {
            for (int k = 0; k < i; k++)   //this loop adds 0s at the end to simulate shift of digits when multiplying.
            {
                tempNumber.Add(0);
            }
            for (int j = 0; j < firstArr.Length; j++)                           // 26 X 58
            {                                                                   //     208
                tempNumber.Add((firstArr[j] * secondArr[i] + remainder) % 10);  //    130
                remainder = (firstArr[j] * secondArr[i] + remainder) / 10;      //    1508
            }
            if (remainder != 0)
            {
                tempNumber.Add(remainder);
            }

            result = SumOfNumbersAsArrays(result, tempNumber);   //Sum the previous number with the current.
            tempNumber.Clear();
            remainder = 0;
        }

        //result.Reverse();
        return string.Join("", result);
    }

    static void Main()
    {

        //Prints all factorials up to 50 without using BigInteger.
        string currentFactorial = "1";
        for (int i = 1; i <= 50; i++)   //This finds all factorials to 50!
        {
            currentFactorial = MultiplyTwoArrays(ConvertToIntArray(currentFactorial), ConvertToIntArray(i.ToString()));
           
            char[] result = currentFactorial.ToCharArray();
            Array.Reverse(result);

            Console.WriteLine(new string(result));
        }
    }
}