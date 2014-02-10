using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteTestWords
{
    /* Write a program that deletes from a text file all words that start with the prefix "test".
     * Words contain only the symbols 0...9, a...z, A…Z, _.
     */

    static void Main()
    {
        using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
            {
                string line = inputReader.ReadLine();
                string pattern = @"\btest\w*";

                while (line != null)
                {
                    var replacedString = Regex.Replace(line, pattern, string.Empty);
                    outputWriter.WriteLine(replacedString);
                    line = inputReader.ReadLine();
                }
                
            }
        }

    }
}
