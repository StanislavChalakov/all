using System;

class MaximalSumOfElements
{
    static void Main()
    {
        Console.Write("How much elements to be contained in the Array : ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.Write("Choose how much elements with maximal sum to be displayed on the screen : ");
        int k = int.Parse(Console.ReadLine());
        if (k <= n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value for element number {0} with index {1} of the Array : ", i + 1, i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int sum = 0;
            Console.Write("The K elements that have maximal sum are : ");
            for (int i = n -k; i < n; i++)
            {
                sum += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("= {0}",sum);
        }
        else
        {
            Console.WriteLine("The chosen length for maximal sum is out of range of the Array's length!");
        }
    }
}

