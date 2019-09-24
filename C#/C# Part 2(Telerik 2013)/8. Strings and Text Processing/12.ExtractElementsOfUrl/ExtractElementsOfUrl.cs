using System;
using System.IO;

class ExtractElementsOfUrl
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        Console.WriteLine("Full url adress is : {0}",url);
        string[] arguments = new string[] { "://", "/" };
        string[] urlElements = url.Split(arguments,3, StringSplitOptions.None);
        Console.WriteLine("URL protokol : {0}",urlElements[0]);
        Console.WriteLine("URL server : {0}",urlElements[1]);
        Console.WriteLine("URL resource : {0}",urlElements[2]);
    }
}

