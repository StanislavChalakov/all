using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 integer numbers");
        Console.WriteLine("enter first number");
        int firstnum = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");
        int secondnum = int.Parse(Console.ReadLine());
        Console.WriteLine("enter third number");
        int thirdnum = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the chosen numbers is {0}",firstnum+secondnum+thirdnum);
    }
}

