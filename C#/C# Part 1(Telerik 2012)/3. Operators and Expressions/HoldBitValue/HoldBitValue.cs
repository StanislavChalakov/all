using System;

class HoldBitValue
{
    static void Main()
    {
        int n = 5;
        int v = 0;
        int p = 2;

        if (v == 1)
        {
            n = n | (1 << p);
            Console.WriteLine(n);
        }
        if (v == 0)
        {
            n = n & (~(1 << p));
            Console.WriteLine(n);
        }
    }
}

