using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        List<int> inBinary = new List<int>();
        while (number > 0)
        {
            inBinary.Add(number % 2);
            number = number / 2;
        }
        Console.Write("Its binary representation is :");
        inBinary.Reverse();
        for (int i = 0; i < inBinary.Count; i++)
        {
            Console.Write(" {0} ", inBinary[i]);
        }
        Console.WriteLine();
    }
}