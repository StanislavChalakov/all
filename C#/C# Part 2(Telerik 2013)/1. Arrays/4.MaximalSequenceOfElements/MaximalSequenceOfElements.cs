using System;

class MaximalSequenceOfElements
{
    static void Main()
    {
        Console.WriteLine("How much elements do you want to be contained in the Array ?");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter integer value for element number {0} with index {1} of the Array:", i + 1 , i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int len = 1;
        int bestLen = 0;
        int bestElement = 0;
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    bestElement = array[i];
                }
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestLen = len;
            bestElement = array[size - 1];
        }
        Console.WriteLine("The Maximal Sequence Of Elements is :");
        Console.Write("{");
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(" {0} ",bestElement);
        }
        Console.Write("}");
        Console.WriteLine();
    }
}

