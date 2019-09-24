using System;

class HelloCSharp
{
    static void Main()
    {
        int i = 2,number;

        for(number = 2;number <= 11;number++)
            if (number % i == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(-number);
            }
    }
}

