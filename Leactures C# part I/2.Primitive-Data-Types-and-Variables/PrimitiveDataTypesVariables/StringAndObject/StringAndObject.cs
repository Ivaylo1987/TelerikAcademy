using System;

class StringAndObject
{
    //Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
    //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
    static void Main()
    {
        string helloVar = "Hello";
        string WorldVar = "World";
        object objVar = helloVar + " " + WorldVar + "!";
        string concatString = (string)objVar;
        Console.WriteLine(concatString);
    }
}
