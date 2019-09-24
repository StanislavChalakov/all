using System;

class NullValuesIntDouble
{
    static void Main()
    {
        Nullable<int> i1 = null;
        double? d2 = null;
        d2 += 0.001;
        Console.WriteLine(d2);
    }
}

