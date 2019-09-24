using System;

class QuotedStrings
{
    static void Main()
    {
        string s_string1 = "The \"use\" of quotations causes difficulties.";
        string s_string2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First way ->{0} \nSecond way ->{1}", s_string1, s_string2);
    }
}

