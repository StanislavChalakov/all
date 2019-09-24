using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = array[0], maxLength = 1, maxIndex = 0;
        for (int i = 1, currentSum = array[0], currentIndex = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            if (array[i] > currentSum)
            {
                currentSum = array[i];
                currentIndex = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxIndex = currentIndex;
                maxLength = i - currentIndex + 1;
            }
        }
        Console.Write("The Sequence of maximal sum is : { ");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0} ",array[maxIndex + i]);
        }
        Console.WriteLine("}");
    }
}

