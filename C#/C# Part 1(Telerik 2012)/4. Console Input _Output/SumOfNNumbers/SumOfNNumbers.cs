using System;

class SumOfNNumbers
{
    static void Main()
    {
        int k;
        Console.WriteLine("Enter some number");
        int n = int.Parse(Console.ReadLine());
        int number;
        int sum=0;
        for (k = 0; k < n; k++)
        {
            Console.WriteLine("Input number");
            number = int.Parse(Console.ReadLine());
            sum += number;
            Console.WriteLine("The sum of N numbers is {0}", sum);
        }      
    }
}

