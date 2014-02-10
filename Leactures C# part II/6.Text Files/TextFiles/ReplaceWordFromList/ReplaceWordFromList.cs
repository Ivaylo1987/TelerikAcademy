using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWordFromList
{
    /* Write a program that removes from a text file all words listed in given another text file.
     * Handle all possible exceptions in your methods.
     */

    static void Main()
    {
        string regExPattern = null;
        try
        {
            using (StreamReader inputReader = new StreamReader(@"..\..\words.txt"))
            {
                string text = inputReader.ReadToEnd();
                var words = Regex.Matches(text, @"\b\w+\b", RegexOptions.IgnorePatternWhitespace);
                List<string> wordsToDelete = new List<string>();

                for (int i = 0; i < words.Count; i++)
                {
                    wordsToDelete.Add(words[i].Value);
                }

                regExPattern = @"\b(" + string.Join("|", wordsToDelete) + @")\b";
            }

            using (StreamWriter outputWriter = new StreamWriter(@"..\..\output.txt"))
            {
                using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
                {
                    string text = inputReader.ReadToEnd();
                    var result = Regex.Replace(text, regExPattern, string.Empty);
                    outputWriter.WriteLine(result);

                    Console.WriteLine("Written to file!");
                }
            }
        }

        catch (FileNotFoundException exp)
        {
            Console.WriteLine(exp.Message);
        }

        catch (DirectoryNotFoundException exp)
        {
            Console.WriteLine(exp.Message);
        }
        catch (PathTooLongException exp)
        {
            Console.WriteLine(exp.Message);
        }

        catch (IOException exp)
        {
            Console.WriteLine(exp.Message);
        }

        catch (UnauthorizedAccessException exp)
        {
            Console.WriteLine(exp.Message);
        }

        catch (ArgumentException exp)
        {
            Console.WriteLine(exp.Message);
        }
    }
}
