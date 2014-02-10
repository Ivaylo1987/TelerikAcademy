using System;
/*Declare a character variable and assign it with the symbol that has Unicode code 72.
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
 */
class AssignChar
{
    static void Main(string[] args)
    {
        char myChar = '\u0048';
        Console.WriteLine(myChar);
    }
}
