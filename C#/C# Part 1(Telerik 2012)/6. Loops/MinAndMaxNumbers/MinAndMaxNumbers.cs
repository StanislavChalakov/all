using System;

class MinAndMaxNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers u want to compare:");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter the {0} number:",i);
            int variable = int.Parse(Console.ReadLine());
            if (variable > max)
            {
                max = variable;
            }
            if (variable < min)
            {
                min = variable;
            }
        }
        Console.WriteLine("The min number is {0}",min);
        Console.WriteLine("The max number is {0}",max);
    }
}

