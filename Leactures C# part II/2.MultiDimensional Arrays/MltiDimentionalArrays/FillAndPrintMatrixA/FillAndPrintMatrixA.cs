using System;

class FillAndPrintMatrixA
{
    //Method for reading the size of the matrix.
    static int[,] DefineMatrix(char matrixName)
    {
        Console.Write("Please, enter Matrix {0} size: ", matrixName);
        int matrixsize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[matrixsize, matrixsize];
        return matrix;
    }

    //Method for printing the matix
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

    //Method for filling up matrix A
    static void FillMatrixA(int[,] matrix)
    {
        int counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter;
                counter++;
            }

        }
    }

    //Method for filling up matrix B
    static void FillMatrixB(int[,] matrix)
    {
        int counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }
    }

    //Method for filling up matrix C
    static void FillMatrixC(int[,] matrix) 
    {
        int counter = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < (matrix.GetLength(1) - row); col++)
            {
                matrix[row + col, col] = counter;
                counter++;
            }
        }

        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - col; row++)
            {
                matrix[row, col + row] = counter;
                counter++;
            }
        }
    }

    //Method for filling up matrix D
    static void FillMatrixD(int[,] matrix) 
    {
        int matrixLastIndex = matrix.GetLength(0) - 1;
        int counter = 1;

        for (int lineIndex = 0; lineIndex <= matrix.GetLength(0) / 2; lineIndex++)
        {
            for (int row = lineIndex; row <= matrixLastIndex - lineIndex; row++)
            {
                matrix[row, lineIndex] = counter;
                counter++;
            }
            for (int col = lineIndex + 1; col <= matrixLastIndex - lineIndex; col++)
            {
                matrix[matrixLastIndex - lineIndex, col] = counter;
                counter++;
            }
            for (int row = matrixLastIndex - lineIndex - 1; row >= lineIndex; row--)
            {
                matrix[row, matrixLastIndex - lineIndex] = counter;
                counter++;
            }
            for (int col = matrixLastIndex - lineIndex - 1; col > lineIndex; col--)
            {
                matrix[lineIndex, col] = counter;
                counter++;
            }
        }
    }

    static void Main()
    {
        int[,] matrixA = DefineMatrix('A');
        FillMatrixA(matrixA);
        PrintMatrix(matrixA);

        int[,] matrixB = DefineMatrix('B');
        FillMatrixB(matrixB);
        PrintMatrix(matrixB);

        int[,] matrixC = DefineMatrix('C');
        FillMatrixC(matrixC);
        PrintMatrix(matrixC);

        int[,] matrixD = DefineMatrix('D');
        FillMatrixD(matrixD);
        PrintMatrix(matrixD);

    }

}
