namespace Frames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Frames
    {
        static string[] permutation;
        static SortedSet<string> permutationsResult = new SortedSet<string>();
        static bool[] used;
        static List<Cell> cells = new List<Cell>();

        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                var current = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
                cells.Add(new Cell(current[0], current[1]));
            }

            used = new bool[cells.Count];
            permutation = new string[cells.Count];
            

            GeneratePermutations(0);

            Console.WriteLine(permutationsResult.Count);
            foreach (var item in permutationsResult)
            {
                Console.WriteLine(item);
            }
        }

        private static void GeneratePermutations(int index)
        {
            if (index == permutation.Length)
            {
                permutationsResult.Add(string.Join(" | ", permutation));
                return;
            }

            for (int i = 0; i < cells.Count; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutation[index] = cells[i].ToString();
                    GeneratePermutations(index + 1);
                    permutation[index] = SwapCell(cells[i]).ToString();
                    GeneratePermutations(index + 1);
                    used[i] = false;
                }
            }
        }

        static Cell SwapCell(Cell cell)
        {
            var newCell = new Cell(cell.Heigt, cell.Width);

            return newCell;
        }

        class Cell
        {
            public Cell(int widht, int height)
            {
                this.Width = widht;
                this.Heigt = height;
            }

            public int Width { get; set; }
            public int Heigt { get; set; }

            public override string ToString()
            {
                return string.Format("({0}, {1})", this.Width, this.Heigt);
            }
        }
    }
}
