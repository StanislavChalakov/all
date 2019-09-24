using System;

class RepeatingNumber
{
    static int HowManyTimesTheNumberIsRepeated(int[] array, int size, int num)
    {
        int counter = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter array length : ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value for element number {0} with index {1} : ",i + 1, i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter what number to inspect : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The element with value : {0} repeats -> ",n);
        Console.Write(HowManyTimesTheNumberIsRepeated(array, size, n));
        Console.WriteLine("times");
    }
}

