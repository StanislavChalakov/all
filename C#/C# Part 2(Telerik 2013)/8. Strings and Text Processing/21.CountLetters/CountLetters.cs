using System;
using System.Collections.Generic;

class CountLetters
{
    static void Main()
    {
        Console.Write("Enter a string to count all his letters : ");
        string str = Console.ReadLine();
        Dictionary<char, int> Letters = new Dictionary<char, int>();
        foreach (var item in str.ToLower())
        {
            if (Char.IsLetter(item))
            {
                if (Letters.ContainsKey(item))
                {
                    Letters[item]++;
                }
                else
                {
                    Letters.Add(item, 1);
                }
            }
        }

        foreach (var letter in Letters)
        {
            Console.WriteLine("{0} - {1} times found", letter.Key, letter.Value);
        }
        Console.WriteLine();
    }
}

