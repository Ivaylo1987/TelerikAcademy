using System;

class Hello
{
    /* Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
     * Write a program to test this method.
     */
    static void HelloGreeting()
    {
        Console.Write("Please, enter your first name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!",name);
    }

    static void Main()
    {
        HelloGreeting();
    }
}
