using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Write a number and press Enter to check if its odd or even:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("number is even");
        }
        else
        {
            Console.WriteLine("number is odd");
        }
    }
}
