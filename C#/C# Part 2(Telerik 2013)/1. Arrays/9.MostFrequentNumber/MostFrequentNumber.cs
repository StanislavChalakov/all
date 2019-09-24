using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("How much elements do you want to be contained in the Array ?");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter integer value for element number {0} with index {1} of the Array:", i + 1, i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxLen = 1,mostFrequent = 0;
        for (int i = 0; i < size - 1; i++)
        {
            int currentLen = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (array[i] == array[j])
                {
                    currentLen++;
                }
            }
            if (currentLen > maxLen)
            {
                maxLen = currentLen;
                mostFrequent = array[i];
            }
        }
        if (maxLen > 1)
        {
            Console.WriteLine("The most frequent number is {0} , repeating {1} times in the Array",mostFrequent,maxLen);
        }
    }
}

