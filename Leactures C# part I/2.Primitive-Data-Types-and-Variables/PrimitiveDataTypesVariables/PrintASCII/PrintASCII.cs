using System;

class PrintASCII
{
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        for (int i = 0; i < 128; i++)
        {
            if ((i <= 32) || (i == 127))
            {
                Console.WriteLine("{0} -> {1}", i, "Ctrl Char");
            }
            else
            {
                Console.WriteLine("{0} -> {1} ", i, Convert.ToChar(i));
            }
        }
    }
}
