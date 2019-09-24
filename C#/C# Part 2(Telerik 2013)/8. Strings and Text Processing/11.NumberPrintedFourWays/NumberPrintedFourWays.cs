using System;

class NumberPrintedFourWays
{
    static void Main()
    {
        Console.WriteLine("Enter some integer number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Its decimal representation is : {0,15}", number);

        Console.WriteLine("Its hexadecimal representation is : {0,15:X}", number);

        Console.WriteLine("Its percentage representation is : {0,15:P}", number);

        Console.WriteLine("Its scientific representation is : {0,15:E}", number);
    }
}

