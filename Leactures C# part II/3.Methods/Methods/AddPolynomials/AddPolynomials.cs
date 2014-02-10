using System;
using System.Collections.Generic;

class AddPolynomials
{
    /* Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5  501
     */

    static void AddPolinoms(string firstPoly, string secondPoly) 
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
        //Sum the common indexes
        for (int i = 0; i < lesserIndex; i++)
        {
            result.Add((firstPoly[i] - '0') + (secondPoly[i] - '0'));
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
        string firstPolynom = "501";
        string secondPolynom = "7233";

        AddPolinoms(firstPolynom, secondPolynom);

    }
}
