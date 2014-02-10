using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SentencesWithIn
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

       var sentences = text.Split('.');

       foreach (var sentence in sentences)
       {
           if (sentence.IndexOf(" in ") >= 0)
           {
               Console.WriteLine(sentence.Trim());
           }
           
       }
    }
}
