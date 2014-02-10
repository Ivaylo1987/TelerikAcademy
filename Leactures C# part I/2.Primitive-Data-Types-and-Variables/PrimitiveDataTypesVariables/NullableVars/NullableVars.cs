using System;

class NullableVars
{
    static void Main()
    {
        int a;
        int? nullableInt = null;
        double? nullableDouble = null;
        Console.WriteLine(3 + nullableInt);
        Console.WriteLine(nullableDouble + nullableInt);
        nullableInt = 4;
        a = (int)(nullableInt + 4);
        Console.WriteLine(a);
    }
}
