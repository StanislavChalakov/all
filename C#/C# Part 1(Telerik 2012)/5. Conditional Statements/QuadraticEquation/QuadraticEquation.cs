using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficient a,b,c of a quadratic equation");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D < 0 && a != 0)
        {
            Console.WriteLine("There is no real roots");
        }
        else if (D == 0 && a != 0)
        {
            Console.WriteLine("The root is: {0}", (double)(-b) / 2 * a);
        }
        else if (D > 0 && a != 0)
        {
            Console.WriteLine("The roots are: {0} {1}", ((-b) - Math.Sqrt(D)) / 2 * a, ((-b) + Math.Sqrt(D)) / 2 * a);
        }
        else
        {
            Console.WriteLine("This is not quadratic equation.");
        }
    }
}

