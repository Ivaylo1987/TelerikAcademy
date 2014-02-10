using System;

class CharArr
{
    static void Main()
    {
        /* Write a program that compares two char arrays lexicographically (letter by letter).
         */

        bool strArr1IsLess = false;
        bool strArr2IsLess = false;
        int shorterLeght;

        //initialize arrays
        Console.Write("Please, enter Array one: ");
        string strArr1 = Console.ReadLine();

        Console.Write("Please, enter Array two: ");
        string strArr2 = Console.ReadLine();


        //find the lexicograficaly less
        if (strArr1.Length > strArr2.Length)
        {
            shorterLeght = strArr2.Length;
            strArr2IsLess = true;
        }
        else if (strArr1.Length < strArr2.Length)
        {
            shorterLeght = strArr1.Length;
            strArr1IsLess = true;
        }
        else // Are equal. Printa and return.
        {
            Console.WriteLine("The tow arrays are equal.");
            return;
        }

        for (int i = 0; i < shorterLeght; i++)
        {
            if (strArr1[i] < strArr2[i])
            {
                strArr1IsLess = true;
                strArr2IsLess = false;
                break;
            }
            else if (strArr1[i] > strArr2[i])
            {
                strArr2IsLess = true;
                strArr1IsLess = false;
                break;
            }
        }

        // print answer
        if (strArr1IsLess)
        {
            Console.WriteLine("{0} is lexicograficaly less than {1}", string.Join(", ", strArr1), string.Join(", ", strArr2));
        }
        else
        {
            Console.WriteLine("{0} is lexicograficaly less than {1}", string.Join(", ", strArr2), string.Join(", ", strArr1));
        }
        
    }
}
