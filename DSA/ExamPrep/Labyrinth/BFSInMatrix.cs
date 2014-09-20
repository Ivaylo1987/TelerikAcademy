namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BFSInMatrix
    {
        private static int labSize = 6;
        private static string[,] labyrinth = new string[,]
                {
                    {"0", "0", "0", "x", "0", "x"},
                    {"0", "x", "0", "x", "0", "x"},
                    {"0", "0", "x", "0", "x", "0"},
                    {"0", "x", "0", "0", "0", "0"},
                    {"0", "0", "0", "x", "x", "0"},
                    {"0", "0", "0", "x", "0", "x"}
                };
        private static HashSet<Cell> used = new HashSet<Cell>();

        private static Queue<Cell> queue = new Queue<Cell>();

        static void Main(string[] args)
        {
            var startElement = new Cell(2, 1, 0);
            BFS(startElement);

            for (int i = 0; i < labSize; i++)
            {
                for (int j = 0; j < labSize; j++)
                {
                    Console.Write(" " + labyrinth[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void BFS(Cell cell)
        {
            queue.Enqueue(cell);
            used.Add(cell);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                labyrinth[current.Row, current.Col] = current.Level.ToString();

                // add up
                if (current.Row - 1 >= 0 && labyrinth[current.Row - 1, current.Col] != "x")
                {
                    var upper = new Cell(current.Row - 1, current.Col, current.Level + 1);
                    if (!used.Contains(upper))
                    {
                        queue.Enqueue(upper);
                        used.Add(upper);
                    }
                }
                // add down
                if (current.Row + 1 < labSize && labyrinth[current.Row + 1, current.Col] != "x")
                {
                    var lower = new Cell(current.Row + 1, current.Col, current.Level + 1);
                    if (!used.Contains(lower))
                    {
                        queue.Enqueue(lower);
                        used.Add(lower);
                    }
                }
                // add left
                if (current.Col - 1 >= 0 && labyrinth[current.Row, current.Col - 1] != "x")
                {
                    var left = new Cell(current.Row, current.Col - 1, current.Level + 1);
                    if (!used.Contains(left))
                    {
                        queue.Enqueue(left);
                        used.Add(left);
                    }
                }
                // add right
                if (current.Col + 1 < labSize && labyrinth[current.Row, current.Col + 1] != "x")
                {
                    var right = new Cell(current.Row, current.Col + 1, current.Level + 1);
                    if (!used.Contains(right))
                    {
                        queue.Enqueue(right);
                        used.Add(right);
                    }
                }
            }
        }
    }

    class Cell
    {
        public Cell(int row, int col, int level)
        {
            this.Row = row;
            this.Col = col;
            this.Level = level;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int Level { get; set; }

        public override bool Equals(object obj)
        {
            var otherCell = obj as Cell;
            if (otherCell == null)
            {
                return false;
            }

            return this.Col == otherCell.Col && this.Row == otherCell.Row;
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode() ^ this.Col.GetHashCode();
        }
    }
}
