using System;

class TypesOfVars
{
    static void Main()
    {
        /* Write a program that, depending on the user's choice inputs int, double or string variable.
         * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
         * The program must show the value of that variable as a console output. Use switch statement.
         */

        Console.Write("Please, enter {0} for \"Int\", {1} for \"Double\" and {2} for \"String\": ", 1, 2, 3);
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Please entera an Int: ");
                int intNumber;
                while (!(int.TryParse(Console.ReadLine(), out intNumber))) //additional check - optional
                {
                    Console.Write("Please, enter a VALID int: ");
                }
                Console.WriteLine(++intNumber);
                break;
            case 2:
                Console.Write("Please entera a Double: ");
                double doubleNumber;
                while (!(double.TryParse(Console.ReadLine(), out doubleNumber))) //additional check - optional
                {
                    Console.Write("Please, enter a VALID double: ");
                }
                Console.WriteLine(++doubleNumber);
                break;
            case 3:
                Console.Write("Please entera a String: ");
                string srtVar = Console.ReadLine();
                Console.WriteLine(srtVar + "*");
                break;
            default:
                Console.WriteLine("bo0m!");
                break;
        }
    }
}
