using System;
using System.Numerics;

{
    class TheSumOfFibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for N = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger a = 1;
            BigInteger b = 0;
            BigInteger sum = 0;

            for (int i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;
                sum += a;
                Console.WriteLine(a);
            }
            Console.WriteLine("The sum of the first {0} numbers is {1}", n, sum);
        }
    }
}
