using System;

class SpiralMatrix
{
    static void Main()
    {
        /* Write a program that reads a positive integer number N
         * (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
         */

        Console.Write("Please, enter size of the matrix: ");
        int matrixSize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[matrixSize, matrixSize]; // initialize a matrix
        int matrixLastLine = matrix.GetLength(0) - 1;   // last index of row or column
        int counter = 1;

        //fill up the spiral matrix
        for (int lineIndex = 0; lineIndex <= matrixSize / 2; lineIndex++)
        {
            for (int row = lineIndex; row <= matrixLastLine - lineIndex; row++)
            {
                matrix[row, lineIndex] = counter;
                counter++;
            }
            for (int col = lineIndex + 1; col <= matrixLastLine - lineIndex; col++)
            {
                matrix[(matrixLastLine - lineIndex), col] = counter;
                counter++;
            }
            for (int row = (matrixLastLine - lineIndex - 1); row >= lineIndex; row--)
            {
                matrix[row, matrixLastLine - lineIndex] = counter;
                counter++;
            }
            for (int col = matrixLastLine - lineIndex - 1; col >= lineIndex + 1; col--)
            {
                matrix[lineIndex, col] = counter;
                counter++;
            }
        }

        //print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
