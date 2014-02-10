using System;
using System.IO;

class Matrix
{
    /* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
     * The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number
     * in a separate text file. 
     */

    static int[,] ReadMatrixFromFile(string fileLocation)
    {
        using (StreamReader inputReader = new StreamReader(fileLocation))
        {
            int matrixSize = int.Parse(inputReader.ReadLine().Trim());
            int[,] matrix = new int[matrixSize, matrixSize];

            string line = inputReader.ReadLine();
            int rowNumber = 0;

            while (line != null)
            {
                var values = line.Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rowNumber, col] = int.Parse(values[col]);
                }

                rowNumber++;
                line = inputReader.ReadLine();
            }

            return matrix;
        }
    }

    static int GetMaxSubSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = int.MinValue;

                currentSum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }

        return bestSum;
    }

    static void Main()
    {
        string fileLocation = @"..\..\input.txt";

        int[,] matrix = ReadMatrixFromFile(fileLocation);

        using (StreamWriter outPut = new StreamWriter(@"..\..\output.txt"))
        {
            outPut.WriteLine(GetMaxSubSum(matrix));
            Console.WriteLine("Written to file!");
        }
    }
}
