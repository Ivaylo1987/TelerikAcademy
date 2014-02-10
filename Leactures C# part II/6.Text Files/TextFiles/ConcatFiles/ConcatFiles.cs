using System;
using System.IO;

class ConcatFiles
{
    /* Write a program that concatenates two text files into another text file.
     */

    static void Main()
    {
        string strInput = null;

        using (StreamReader inputReader = new StreamReader(@"..\..\firstInput.txt"))
        {
            strInput = inputReader.ReadToEnd();
        }

        using (StreamReader inputReader = new StreamReader(@"..\..\secondInput.txt"))
        {
            strInput += inputReader.ReadToEnd();
        }

        using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt", false))
        {
            outputWriter.WriteLine(strInput);
        }
        Console.WriteLine("You can check file :)");
    }
}
