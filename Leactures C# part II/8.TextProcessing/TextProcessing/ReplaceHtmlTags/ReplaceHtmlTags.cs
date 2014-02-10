using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceHtmlTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string pattern = @"(<a)\s+(href="")(.+?)"">(.+?)(</a>)";

        var result = Regex.Replace(text, pattern, "[URL=$3]$4[/URL]");   //$3, $4 replacement for group 3 and 4 in regex

        Console.WriteLine(result);
    }
}
