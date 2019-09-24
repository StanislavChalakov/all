using System;

class MultiplicationFactorials
{
    static void Main()
    {
        int k;
        int n;
        int nfactirial = 1;
        int kfactorial = 1;
        int kMinusNFactorial = 1;
        Console.WriteLine("Enter two numbers (1 < N < K) :");
        Console.Write("K = ");
        int.TryParse(Console.ReadLine(), out k);
        Console.Write("N = ");
        int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= k; i++)
        {
            nfactirial *= i;
            if (i <= n)
                kfactorial *= i;
            if (i <= (k - n))
                kMinusNFactorial *= i;
        }
        Console.WriteLine("{0}! * {1}! / ({0} - {1})! = {2}", k, n, (nfactirial * kfactorial) / kMinusNFactorial);
    }
}

