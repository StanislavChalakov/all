using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number whose index you want to see : ");
        int searchedNumber = int.Parse(Console.ReadLine());
        Console.Write("How much elements to be contained in the Array : ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value for element number {0} with index {1} of the Array : ", i + 1, i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int iMin = 0;
        int iMax = size - 1;
        int iMid = 0;
        while (iMin <= iMax)
        {
            iMid = (iMin + iMax) / 2;
            if (array[iMid] < searchedNumber)
            {
                iMin = iMid + 1;
            }
            else if (array[iMid] > searchedNumber)
            {
                iMax = iMid - 1;
            }
            else
            {
                break;
            }
        }
        if (array[iMid] == searchedNumber)
        {
            Console.WriteLine("The searched number with value {0} has index {1} in the sorted array", searchedNumber, iMid);
        }
        else
        {
            Console.WriteLine("The searched number is not contained in the array");
        }
    }
}

