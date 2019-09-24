using System;

class AllNumbersInOneLine
{
    static void Main()
    {
        Console.WriteLine("Enter some number please:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to {0} are:",n);
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ",i);
        }


    }
}
