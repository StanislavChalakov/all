using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        c = a;
        a = b;
        b = c;
        Console.WriteLine("The new value of a ->{0} \nThe new value of b ->{1}", a, b);
    }
}
