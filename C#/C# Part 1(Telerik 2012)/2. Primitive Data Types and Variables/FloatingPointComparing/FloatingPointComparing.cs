using System;

class FloatingPointComparing
{
    static void Main()
    {
        double a = 6.00000001d;
        double b = 6.00000006d;

        if (a > b)
        {
            if ((a - b) < 0.000001d)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        if (b > a)
        {
            if ((b - a) < 0.000001d)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

