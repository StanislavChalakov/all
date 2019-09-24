using System;

class StringOfTwentyCharacters
{
    static void Main()
    {
        Console.Write("Enter some text with less than 20 characters : ");
        string text = Console.ReadLine();
        if (text.Length < 20)
        {
            int length = 20-text.Length;
            string secondText = new string('*', length);
            text=text+secondText;
        }
        else
        {
            Console.WriteLine("The entered text is longer than 20 characters");
        }
        Console.WriteLine("The entered text,filled with stars, looks like this : {0}",text);
    }
}

