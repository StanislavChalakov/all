using System;

class TheGreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Enter five variables:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The greatest number is {0}", a);
        }
        else if (b > c && b > d && b > e)
        {
            Console.WriteLine("The greatest number is {0}", b);
        }
        else if (c > d && c > e)
        {
            Console.WriteLine("The greatest number is {0}", c);
        }
        else if (d > e)
        {
            Console.WriteLine("The greatest number is {0}", d);
        }
        else
        {
            Console.WriteLine("The greatest number is {0}", e);
        }
    }
}

