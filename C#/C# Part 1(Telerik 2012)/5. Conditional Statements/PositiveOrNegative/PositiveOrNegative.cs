using System;

class PositiveOrNegative
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        if ((firstNum > 0 && secondNum > 0 && thirdNum > 0) || (firstNum < 0 && secondNum < 0 && thirdNum > 0) || (firstNum > 0 && secondNum < 0 && thirdNum < 0) || (firstNum < 0 && secondNum > 0 && thirdNum < 0))
        {
            Console.WriteLine("The product is possitive");
        }
        else { Console.WriteLine("The product is negative"); }
    }
}

