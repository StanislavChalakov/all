using System;

class FillsAndPrintsMatrix
{
    static void Main()
    {
        int[,] matrix = new int[4, 4];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter value for element on row number {0},column number {1} : ", row + 1, col + 1);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" {0,4} ",matrix[col,row]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

