namespace MatrixWalk
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class Entry
    {
        public const int MAX_MATRIX_SIZE = 100;
        public const int MIN_MATRIX_SIZE = 1;

        [ExcludeFromCodeCoverage]
        public static void Main()
        {
            GameField gameField = new GameField(GetUserInput(), GenerateDirectionsList());

            int cellValue = 1;
            bool noPossibleDirections = false;

            while (true)
            {
                if (gameField.MakeMove(cellValue))
                {
                    cellValue++;
                }
                else
                {
                    // Trying all possible directions starting from current one +1;
                    for (int i = 0; i < gameField.Directions.Count; i++)
                    {
                        gameField.CurrentDirectionIndex++;

                        // If the end of the list is reached...reset
                        if (gameField.CurrentDirectionIndex >= gameField.Directions.Count)
                        {
                            gameField.CurrentDirectionIndex = 0;
                        }

                        // Try to make a move for each new direction. If a directions is found we break the "direction search cicle"
                        if (gameField.MakeMove(cellValue))
                        {
                            cellValue++;
                            noPossibleDirections = false;
                            break;
                        }

                        noPossibleDirections = true;
                    }
                }

                if (noPossibleDirections)
                {
                    // When no empty cell is available at all directions, the walk is restarted
                    if (gameField.GoToUsableCell(cellValue))
                    {
                        gameField.CurrentDirectionIndex = 0;
                        noPossibleDirections = false;
                    }
                    else
                    {
                        // When no empty cell is left in the matrix, the walk is finished.
                        break;
                    }
                }
            }

            Console.WriteLine(gameField.ToString());
        }

        private static int GetUserInput()
        {
            Console.WriteLine("Enter a positive number for matrix size");
            string input = Console.ReadLine();

            int matrixSize = 0;
            while (!int.TryParse(input, out matrixSize) || matrixSize < MIN_MATRIX_SIZE || matrixSize > MAX_MATRIX_SIZE)
            {
                Console.WriteLine("Please enter a number between 1 and 100");
                input = Console.ReadLine();
            }

            return matrixSize;
        }

        private static IList<IDirection> GenerateDirectionsList()
        {
            IList<IDirection> directions = new List<IDirection>();

            directions.Add(new Direction(1, 1));
            directions.Add(new Direction(1, 0));
            directions.Add(new Direction(1, -1));
            directions.Add(new Direction(0, -1));
            directions.Add(new Direction(-1, -1));
            directions.Add(new Direction(-1, 0));
            directions.Add(new Direction(-1, 1));
            directions.Add(new Direction(0, 1));

            return directions;
        }
    }
}
