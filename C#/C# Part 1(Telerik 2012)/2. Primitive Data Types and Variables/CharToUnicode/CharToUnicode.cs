using System;

class CharToUnicode
{
    static void Main()
    {
        int a = 72;
        char c = (char)a;
        Console.WriteLine(c);

        char c2 = '\u0048';
        Console.WriteLine(c2);
    }
}
