using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter first number:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number:");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater of two is:");
        Console.WriteLine(Math.Max(firstNum, secondNum));
    }
}

