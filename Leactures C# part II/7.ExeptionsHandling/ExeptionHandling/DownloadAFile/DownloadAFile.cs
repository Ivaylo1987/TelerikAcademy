using System;
using System.Net;

class DownloadAFile
{
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();

            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "basdPic.jpg");

            webClient.Dispose();

            Console.WriteLine("Downloaded!");
        }
        catch (ArgumentException exp)
        {
            Console.WriteLine(exp.Message);
        }
        catch (WebException exp)
        {
            Console.WriteLine(exp.Message);
        }
        catch (NotSupportedException exp)
        {
            Console.WriteLine(exp.Message);
        }
        
    }
}
