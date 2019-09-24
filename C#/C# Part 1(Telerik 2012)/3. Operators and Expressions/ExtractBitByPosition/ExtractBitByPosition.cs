using System;

    class ExtractBitByPosition
    {
        static void Main()
        {
            int n = 5;
            int p = 2;
            int mask = 1;
            mask = mask << p;
            mask = mask & n;
            mask = mask >> p;
            Console.WriteLine("{0}",mask);
        }
    }

