using System;

class SelectionSortArray
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
        for (int i = 0; i < size - 1; i++)
        {
            
            int iMin = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[iMin])
                {
                    iMin = j;
                }
            }
            if (iMin != i)
	        {
                int temp = 0;
                temp = array[i];
                array[i] = array[iMin];
                array[iMin] = temp;
	        }
        }
        Console.Write("The sorted array looks like this : ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine();
    }
}

