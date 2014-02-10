using System;
using System.Collections.Generic;

class MultiplyAndSubtractPolynomials
{
    /* Extend the previous program to support also subtraction and multiplication of polynomials.
     */

    static void MultiplyPolynomials(string firstPoly, string secondPoly)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < secondPoly.Length; i++)
        {
            for (int j = 0; j < firstPoly.Length; j++)
            {
                if (i + j >= result.Count)
                {
                    result.Add((firstPoly[j] - '0') * (secondPoly[i] - '0'));
                }
                else
                {
                    result[i + j] += (firstPoly[j] - '0') * (secondPoly[i] - '0');
                }
            }
        }

        Console.WriteLine(String.Join(", ", result));
    }

    static void SubtractPolinomials(string firstPoly, string secondPoly)   //Subtracts first polynom - second polynom
    {
        List<int> result = new List<int>();
        int lesserIndex;
        int greaterIndex;
        string LongerString;   //indicates the longer polinomial

        if (firstPoly.Length > secondPoly.Length)
        {
            greaterIndex = firstPoly.Length;
            lesserIndex = secondPoly.Length;
            LongerString = firstPoly;
        }
        else
        {
            greaterIndex = secondPoly.Length;
            lesserIndex = firstPoly.Length;
            LongerString = secondPoly;
        }

        //Subtract the common indexes
        for (int i = 0; i < lesserIndex; i++)
        {
            result.Add((firstPoly[i] - '0') - (secondPoly[i] - '0'));
        }

        //Sum those indexes that are not common
        for (int i = lesserIndex; i < greaterIndex; i++)
        {
            result.Add(LongerString[i] - '0');
        }

        Console.WriteLine(String.Join(", ", result));
    }

    static void Main()
    {
        string firstPolynom = "123";
        string secondPolynom = "11";

        MultiplyPolynomials(firstPolynom, secondPolynom);
        SubtractPolinomials(firstPolynom, secondPolynom);
    }
}