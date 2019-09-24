using System;

class PrimeNumber
{
    static void Main()
    {
        int a = 41;
        int b = 0;
        for (int i = a - 1; i > 1; i--)
        {
            if (a % i == 0)
            {
                b = 1;
            }

        }
        if (b == 1) 
        { 
            Console.WriteLine("The digit {0} is not prime", a); 
        }
        else 
        { 
            Console.WriteLine("The digit {0} is prime", a); 
        }
    }
}

