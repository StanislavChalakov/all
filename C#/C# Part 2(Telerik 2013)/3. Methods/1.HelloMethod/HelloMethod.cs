using System;

class HelloMethod
{
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        SayHello(Console.ReadLine());
    }
}

