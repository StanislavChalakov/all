using System;

class PrintNumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number to see all number between 1 and N:");
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        int sum = 1;

        Console.Write("The sum 1");
        while (number < n)
        {
            number++;
            sum += number;
            Console.Write("+{0}", number);
        }
        Console.WriteLine(" = {0}", sum);
    }
}
