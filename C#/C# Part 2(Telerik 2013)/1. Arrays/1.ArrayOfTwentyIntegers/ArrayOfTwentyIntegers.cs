using System;

class ArrayOfTwentyIntegers
{
    static void Main()
    {
        int[] arrayOfIntegers = new int[20];
        int length = arrayOfIntegers.Length;
        for (int i = 0; i < length; i++)
        {
            arrayOfIntegers[i] = i * 5;
            Console.WriteLine("Array's element {0} with index {1} multiplied by 5 is equal to {2}", i + 1, i, arrayOfIntegers[i]);
        }
    }
}