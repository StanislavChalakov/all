using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Write some number to check third bit");
        int digit = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        mask = digit & mask;
        mask = mask >> 3;
        if (mask == 0)
        {
            Console.WriteLine("The third bit is {0} ", mask);
        }
        else
        {
            Console.WriteLine("The third bit is {0} ", mask);
        }
    }
}

