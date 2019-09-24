using System;

class DivideTwoFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter first factoriel:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second factoriel:");
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = (k + 1); i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}

