using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ParseURL
{
    /* Write a program that parses an URL address given in the format:
     * and extracts from it the [protocol], [server] and [resource] elements.
     * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
     * [protocol] = "http"
     * [server] = "www.devbg.org"
     * [resource] = "/forum/index.php"

     */
    static void Main()
    {
        string text = @"http://www.devbg.org/forum/index.php";
        string pattern = @"(\w+)[:/]+([\w.]+)[/]+([\w./]+)";

        var result = Regex.Matches(text, pattern);


        foreach (Match item in result)
        {
            Console.WriteLine("Protocol: {0}", item.Groups[1].Value);
            Console.WriteLine("Server: {0}", item.Groups[2].Value);
            Console.WriteLine("Server: {0}", item.Groups[3].Value);
        }
        
    }
}
