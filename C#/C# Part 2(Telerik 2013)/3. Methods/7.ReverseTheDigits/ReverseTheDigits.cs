using System;

class ReverseTheDigits
{
    static void ReverseDigits(decimal number)
    {
        string reversed = number.ToString();

        char[] charArray = reversed.ToCharArray();
        Array.Reverse(charArray);
        new string(charArray);
        Console.WriteLine(charArray);
    }
    static void Main()
    {
        Console.Write("What number to be reversed : ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.Write("The reversed number is -> ");
        ReverseDigits(number);
    }
}
