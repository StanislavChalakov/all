using System;

class ComparingIntegerArrays
{
    static void Main()
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        int length = firstArray.Length;

        Console.WriteLine("Please Enter five integers for the first Array");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Array`s member {0} with index {1} has value:",i+1 , i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please Enter five integers for the second Array");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Array`s member {0} with index {1} has value:", i + 1, i);
            secondArray[i] = int.Parse(Console.ReadLine());
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
            Console.WriteLine("The Entered Arrays are not identical !");
        }
        else
        {
            Console.WriteLine("The Entered Arrays are identical !");
        }
    }
}

