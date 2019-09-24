using System;

class ConvertToUnicode
{
    static void Main()
    {
        string str = "Hi!";

        foreach (var symbol in str)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}

