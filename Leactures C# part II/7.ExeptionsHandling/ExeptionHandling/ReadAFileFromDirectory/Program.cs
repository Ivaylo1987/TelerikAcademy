using System;
using System.IO;

class ReadAFileFromDirectory
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please enter a valid file path and file name: ");
            string fileDetails = Console.ReadLine();

            Console.WriteLine(File.ReadAllText(fileDetails));
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("No such dir exists!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null file path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong file path");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized Access!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }
}
