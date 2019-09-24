using System;

class TheGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int firstnumb = int.Parse(Console.ReadLine());
        int secondnumb = int.Parse(Console.ReadLine());
        int thirdnumb;
        if (secondnumb < firstnumb)
        {
            thirdnumb = firstnumb;
            firstnumb = secondnumb;
            secondnumb = thirdnumb;
        }
        Console.WriteLine("The Greater number is {0}", secondnumb);
    }
}

