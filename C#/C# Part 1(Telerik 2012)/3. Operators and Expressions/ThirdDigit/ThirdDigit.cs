using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Write 3 digit number at least:");
        int digit = int.Parse(Console.ReadLine());
        digit = digit / 100;
        if (digit % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

