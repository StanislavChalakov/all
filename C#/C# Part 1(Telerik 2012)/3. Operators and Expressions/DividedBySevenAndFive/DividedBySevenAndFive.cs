using System;

class DividedBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Write a number and press Enter to check if it can be divided by seven and five at the same time:");
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("number={0} can be devided by five and seven at the same time", number);
        }
        else
        {
            Console.WriteLine("number={0} can not be devided by five and seven at the same time", number);
        }

    }
}

