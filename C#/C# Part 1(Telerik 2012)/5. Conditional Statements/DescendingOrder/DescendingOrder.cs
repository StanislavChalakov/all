using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        if (first > second && first > third)
        {
            if (second > third)
            {
                Console.WriteLine("The Descending Order is {0} {1} {2}", first, second, third);
            }
            else { Console.WriteLine("The Descending Order is {0} {2} {1}", first, second, third); }
        }
        else if (second > third)
        {
            if (first > third)
            {
                Console.WriteLine("The Descending Order is {1} {0} {2}", first, second, third);
            }
            else { Console.WriteLine("The Descending Order is {1} {2} {0}", first, second, third); }
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("The Descending Order is {2} {0} {1}", first, second, third);
            }
            else
            {
                Console.WriteLine("The Descending Order is {2} {1} {0}", first, second, third);

            }
        }
    }
}

