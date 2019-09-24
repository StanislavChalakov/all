using System;

class ReverseTheWords
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] words = sentence.Split(' ', '!');
        Array.Reverse(words);
        for (int i = 0; i < words.Length; i++)
        {
                Console.Write("{0} ",words[i]);
        }
        Console.WriteLine();
    }
}

