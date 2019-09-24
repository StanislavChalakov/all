using System;

class ComparingCharArrays
{
    static void Main()
    {
        char[] firstArray = new char[5];
        int length = firstArray.Length;
        char[] secondArray = new char[5];

        Console.WriteLine("Please Enter five characters for the first Array");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("First Array`s member {0} with index {1} has value:", i + 1, i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please Enter five characters for the second Array");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Second Array`s member {0} with index {1} has value:", i + 1, i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        bool equal = true;
        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
            }
        }

        if (equal == false)
        {
            Console.WriteLine("The Entered Arrays are not identical lexicographically !");
        }
        else
        {
            Console.WriteLine("The Entered Arrays are identical lexicographically !");
        }
    }
}