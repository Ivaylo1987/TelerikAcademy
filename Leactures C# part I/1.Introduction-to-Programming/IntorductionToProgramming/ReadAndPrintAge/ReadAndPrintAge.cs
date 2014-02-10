using System;

class ReadAndPrintAge
{
    static void Main()
    {
        Console.Write("Please, enter your age: ");
        string strAge = Console.ReadLine();
        int myAge = int.Parse(strAge);
        Console.WriteLine("In 10 years you will be {0}. ", (myAge + 10));
    }
}