using System;

class Program
{
    /*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
     */
    static void Main()
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = {0} and b = {1}.", a, b);
    }
}
