using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("How much elements to be contained in the Array : ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value for element number {0} with index {1} of the Array : ", i + 1, i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Searched Sum of sequence of three elements : ");
        int sum = int.Parse(Console.ReadLine());
        for (int i = 0; i < size - 2; i++)
        {
            if (array[i] + array[i + 1] + array[i + 2] == sum)
            {
                Console.WriteLine("The sequence of three elements with Sum = {0} is {1} , {2} , {3}",sum,array[i],array[i + 1],array[i + 2]);
            }
        }
    }
}

