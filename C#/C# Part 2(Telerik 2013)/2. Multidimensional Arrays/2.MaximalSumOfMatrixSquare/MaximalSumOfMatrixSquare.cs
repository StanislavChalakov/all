using System;

class MaximalSumOfMatrixSquare
{
    static void Main()
    {
        Console.Write("Enter how many rows do you want to present in the matrix : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter how many columns do you want to present in the matrix : ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix= new int[n,m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter value for element on row number {0},column number {1} : ", i + 1, j + 1);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int currentSum = 0,bestSum = 0,bestRow = 0,bestCol = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                for (int row = i; row <= i + 2; row++)
                {
                    for (int col = j; col <= j + 2; col++)
                    {
                        currentSum += matrix[row, col];
                    }
                }
                if (currentSum >= bestSum)
                {
                    bestSum = currentSum;
                    bestRow = i;
                    bestCol = j;
                    currentSum = 0;
                }
                else if (currentSum < bestSum)
                {
                    currentSum = 0;
                }
            }
        }
        Console.WriteLine("The square of elements in the array with maximal sum = {0} is : ",bestSum);
        Console.WriteLine();
        for (int i = bestRow; i <= bestRow + 2; i++)
        {
            for (int j = bestCol; j <= bestCol + 2; j++)
            {
                Console.Write(" {0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

