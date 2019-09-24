using System;

class TheBiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else
        {
            if (b > a && a > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
        }
    }
}

