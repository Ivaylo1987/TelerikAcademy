using System;

class Triangle
{
    /* Write a program that prints an isosceles triangle of 9 copyright symbols ©.
     * Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
     * 
     * The task is the same BUT it prints a tree not a triagle:)
     */
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Please enter size N: ");
        int n = int.Parse(Console.ReadLine());

        int width = (n * 2 - 3);
        int height = n - 1;
        char[,] tree = new char[height, width];
        char[] treeTrunk = new char[width];
        char copyR = '\u00A9';
        char dotChar = ' ';

        // Building the Tree itself.
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((width / 2 - i <= j) && (j <= width / 2 + i))
                {
                    tree[i, j] = copyR;
                }
                else
                {
                    tree[i, j] = dotChar;
                }
            }
        }

        //Building the trunk
        for (int i = 0; i < width; i++)
        {
            if (i == width / 2)
            {
                treeTrunk[i] = copyR;
            }
            else
            {
                treeTrunk[i] = dotChar;
            }
        }

        //Printing the tree
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(tree[i, j] + " ");
            }
            if (i != (n - 1))
            {
                Console.WriteLine();
            }
        }

        //printing the trunk
        for (int i = 0; i < width; i++)
        {
            Console.Write(treeTrunk[i] + " ");
        }
        Console.WriteLine();
    }
}
