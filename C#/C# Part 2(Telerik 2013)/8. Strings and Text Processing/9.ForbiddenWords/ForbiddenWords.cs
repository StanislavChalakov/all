using System;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidenWords = { "PHP", "CLR", "Microsoft" };
        for (int i = 0; i < forbidenWords.Length; i++)
        {
            text = text.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }
        Console.WriteLine(text);
    }
}

