using System;

class FillMatrix
{
    static void Main()
    {
        //

        Console.Write("Please, enter size of the matrix: ");
        int matrixSize = int.Parse(Console.ReadLine());

        for (int row = 1; row <= matrixSize; row++)
        {
            for (int num = row; num < row + matrixSize; num++)
            {
                Console.Write("{0, 4}", num);
            }
            Console.WriteLine();
        }
    }
}
