using System;

class MaxSumOfElements
{

    /* Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3
     * that has maximal sum of its elements.
     */

    //Method for initializing matrix with random digits for testing purposes.
    static int[,] InputMatrix() 
    {
        Console.Write("Please, enter number of rows: ");
        int rowsOfMatrix = int.Parse(Console.ReadLine());

        Console.Write("Please, enter number of collumns: ");
        int colsOfMatrix = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rowsOfMatrix, colsOfMatrix];

        Random randomGen = new Random();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = randomGen.Next(-20, 20);   // Input is random numbers for testing purposes.
            }
        }

        return matrix;
    }

    //Print matrix method
    static void PrintMatrix(int[,] matrix) 
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    //Method that finds max sum
    //It returs three values the max sum, the row and the col where the max sum starts
    static int GetMaxSum(int[,] matrix, out int indexOfRow, out int indexOfCol) 
    {
        int tempSum = 0;
        int sum = int.MinValue;
        indexOfRow = 0;
        indexOfCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                tempSum = 0;

                for (int i = row; i < row + 3; i++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        tempSum += matrix[i, j];
                    }
                }

                if (tempSum > sum)
                {
                    sum = tempSum;
                    indexOfRow = row;
                    indexOfCol = col;
                }
            }
        }

        return sum;
    }

    static void Main()
    {
        int RowOfMaxSum;
        int ColOfMaxSum;
        int[,] matrix = InputMatrix();
        PrintMatrix(matrix);
        int maxSum = GetMaxSum(matrix, out RowOfMaxSum, out ColOfMaxSum);

        Console.WriteLine(maxSum);
        Console.WriteLine(RowOfMaxSum);
        Console.WriteLine(ColOfMaxSum);
    }
}
