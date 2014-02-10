using System;
using System.Text;

class LongestStringSequence
{
    /* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor
     * elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal
     * strings in the matrix. 
     */

    static string FindMaxEqualSequence(string[,] inputMatrix)
    {
        int bestSequnce = 1; //lenght of the sequence of equal elements
        string sequenceElement = inputMatrix[0, 0]; //the sequence element

        //Check on rows
        for (int row = 0; row < inputMatrix.GetLength(0); row++)
        {
            int currentSequence = 1;
            for (int col = 0; col < inputMatrix.GetLength(1) - 1; col++)
            {
                if (inputMatrix[row, col] == inputMatrix[row, col + 1]) //if true increase with 1 and check if best
                {
                    currentSequence++;

                    if (currentSequence > bestSequnce)
                    {
                        bestSequnce = currentSequence;
                        sequenceElement = inputMatrix[row, col];
                    }
                }
                else //else start over the sequence form 1
                {
                    currentSequence = 1;
                }
            }
        }

        //Check on columns
        for (int col = 0; col < inputMatrix.GetLength(1); col++)
        {
            int currentSequence = 1;
            for (int row = 0; row < inputMatrix.GetLength(0) - 1; row++)
            {
                if (inputMatrix[row, col] == inputMatrix[row + 1, col])
                {
                    currentSequence++;

                    if (currentSequence > bestSequnce)
                    {
                        bestSequnce = currentSequence;
                        sequenceElement = inputMatrix[row, col];
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
        }

        //Check left diagonal
        for (int row = 0; row < inputMatrix.GetLength(0); row++)
        {
            int currentSequence = 1;
            int index = 1;
            for (int col = 0; col < inputMatrix.GetLength(1); col++)
            {
                while (row + index < inputMatrix.GetLength(0) && col + index < inputMatrix.GetLength(1))
                {
                    if (inputMatrix[row, col] == inputMatrix[row + index, col + index])
                    {
                        currentSequence++;

                        if (currentSequence > bestSequnce)
                        {
                            bestSequnce = currentSequence;
                            sequenceElement = inputMatrix[row, col];
                        }
                    }
                    else
                    {
                        currentSequence = 1;
                        index = 1;
                        break;
                    }

                    index++;
                }
            }
        }

        //Check right diagonal
        for (int row = 0; row < inputMatrix.GetLength(0); row++)
        {
            int currentSequence = 1;
            int index = 1;
            for (int col = inputMatrix.GetLength(1) - 1; col >= 0 ; col--)
            {
                while (row + index < inputMatrix.GetLength(0) && col - index >= 0)
                {
                    if (inputMatrix[row, col] == inputMatrix[row + index, col - index])
                    {
                        currentSequence++;

                        if (currentSequence > bestSequnce)
                        {
                            bestSequnce = currentSequence;
                            sequenceElement = inputMatrix[row, col];
                        }
                    }
                    else
                    {
                        currentSequence = 1;
                        index = 1;
                        break;
                    }

                    index++;
                }
            }
        }

        StringBuilder result = new StringBuilder();   //will hold the sequence 
        for (int i = 0; i < bestSequnce; i++)
        {
            if (i != 0)
            {
                result.Append(", ");
            }
            result.Append(sequenceElement);
        }

        return result.ToString();
    }

    static void Main()
    {
        string[,] matrix = new string[,]
        {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"}
        };

        Console.WriteLine(FindMaxEqualSequence(matrix));
    }
}
