using System;

class SortStringArrayByElementSize
{
    /* You are given an array of strings. Write a method that sorts the array by the length
     * of its elements (the number of characters composing them).
     */

    static void Main()
    {
        string[] strArray = {"testString414141", "ivo", "ivaylo", "hristov", "TelerikAcademy" };

        Array.Sort(strArray, (x, y) => x.Length.CompareTo(y.Length));   //sort with landa expression
        
        foreach (var element in strArray)
	    {
		    Console.WriteLine(element);
	    }
    }
}
