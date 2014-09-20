namespace _3DLabyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static char[, ,] labyrinth;
        static HashSet<Cell> used = new HashSet<Cell>();
        static int[] lrc;

        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(el => int.Parse(el)).ToArray();
            var startCell = new Cell(input[0], input[1], input[2], 0);

            lrc = Console.ReadLine().Split(' ').Select(el => int.Parse(el)).ToArray();
            labyrinth = new char[lrc[0], lrc[1], lrc[2]];

            for (int level = 0; level < lrc[0]; level++)
            {
                for (int row = 0; row < lrc[1]; row++)
                {
                    var line = Console.ReadLine();
                    for (int col = 0; col < lrc[2]; col++)
                    {
                        labyrinth[level, row, col] = line[col];
                        if (labyrinth[level, row, col] == '#')
                        {
                            used.Add(new Cell(level, row, col, 0));
                        }
                    }
                }
            }

            //Console.WriteLine("{0}, {1}, {2}", lrc[0], lrc[1], lrc[2]);
            BFS(startCell);

        }

        private static void BFS(Cell cell)
        {
            var queue = new Queue<Cell>();
            var totalCount = 0;

            queue.Enqueue(cell);
            used.Add(cell);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                var count = 0;
                totalCount = current.Level;


                // add back
                if (current.Row - 1 >= 0)
                {
                    count++;
                    var upper = new Cell(current.Level, current.Row - 1, current.Col, current.StepsSoFar + 1);
                    if (!used.Contains(upper))
                    {
                        queue.Enqueue(upper);
                        used.Add(upper);
                    }
                }
                // add forth
                if (current.Row + 1 < lrc[1])
                {
                    var lower = new Cell(current.Level, current.Row + 1, current.Col, current.StepsSoFar + 1);
                    if (!used.Contains(lower))
                    {
                        queue.Enqueue(lower);
                        used.Add(lower);
                    }
                }
                // add left
                if (current.Col - 1 >= 0)
                {
                    var left = new Cell(current.Level, current.Row, current.Col - 1, current.StepsSoFar + 1);
                    if (!used.Contains(left))
                    {
                        queue.Enqueue(left);
                        used.Add(left);
                    }
                }
                // add right
                if (current.Col + 1 < lrc[2])
                {
                    var right = new Cell(current.Level, current.Row, current.Col + 1, current.StepsSoFar + 1);
                    if (!used.Contains(right))
                    {
                        queue.Enqueue(right);
                        used.Add(right);
                    }
                }

                // add up
                if (labyrinth[current.Level, current.Row, current.Col] == 'U')
                {
                    if (current.Level + 1 >= lrc[0])
                    {
                        Console.WriteLine(current.StepsSoFar + 1);
                        return;
                    }

                    var up = new Cell(current.Level + 1, current.Row, current.Col, current.StepsSoFar + 1);
                    
                    if (!used.Contains(up))
                    {
                        queue.Enqueue(up);
                        used.Add(up);
                    }
                }

                // add down
                if (labyrinth[current.Level, current.Row, current.Col] == 'D')
                {
                    if (current.Level - 1 < 0)
                    {
                        Console.WriteLine(current.StepsSoFar + 1);
                        return;
                    }

                    var down = new Cell(current.Level - 1, current.Row, current.Col, current.StepsSoFar + 1);
                    if (!used.Contains(down))
                    {
                        queue.Enqueue(down);
                        used.Add(down);
                    }
                }
            }
        }

    }

    class Cell
    {
        public Cell(int level, int row, int col, int stepsSoFar)
        {
            this.Level = level;
            this.Row = row;
            this.Col = col;
            this.StepsSoFar = stepsSoFar;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int Level { get; set; }
        public int StepsSoFar { get; set; }

        public override bool Equals(object obj)
        {
            var otherCell = obj as Cell;
            if (otherCell == null)
            {
                return false;
            }

            return this.Col == otherCell.Col && this.Row == otherCell.Row && this.Level == otherCell.Level;
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode() ^ this.Col.GetHashCode() ^ this.Level.GetHashCode();
        }
    }
}
