namespace MatrixWalk
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;
    
    public class GameField
    {
        public const int START_DIRECTION_INDEX = 0;

        private int size;
        private int currentDirectionIndex;
        private int rowPos;
        private int colPos;

        public GameField(int size, IList<IDirection> directions)
        {
            this.Size = size;
            this.Field = new int[this.Size, this.Size];
            this.Directions = directions;
            this.CurrentDirectionIndex = START_DIRECTION_INDEX;

            this.rowPos = -1;
            this.colPos = -1;
        }

        public IList<IDirection> Directions { get; set; }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Matrix size cannot be less than 1");
                }

                this.size = value;
            }
        }

        public int CurrentDirectionIndex
        {
            get
            {
                return this.currentDirectionIndex;
            }

            set
            {
                if (value > this.Directions.Count)
                {
                    this.currentDirectionIndex = START_DIRECTION_INDEX;
                }
                else
                {
                    this.currentDirectionIndex = value;
                }
            }
        }

        private int[,] Field { get; set; }

        public bool GoToUsableCell(int cellValue)
        {
            for (int rows = 0; rows < this.Size; rows++)
            {
                for (int cols = 0; cols < this.Size; cols++)
                {
                    if (this.Field[rows, cols] == 0)
                    {
                        this.rowPos = rows;
                        this.colPos = cols;
                        this.Field[this.rowPos, this.colPos] = cellValue;

                        return true;
                    }
                }
            }

            return false;
        }

        public bool MakeMove(int cellValue)
        {
            int nextRow = this.rowPos + this.Directions[this.CurrentDirectionIndex].X;
            int nextCol = this.colPos + this.Directions[this.CurrentDirectionIndex].Y;

            if (this.IsInFieldRange(nextRow) && this.IsInFieldRange(nextCol) && this.IsNextCellFree(nextRow, nextCol))
            {
                this.rowPos = nextRow;
                this.colPos = nextCol;

                this.Field[this.rowPos, this.colPos] = cellValue;

                return true;
            }

            return false;
        }

        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int rows = 0; rows < this.Size; rows++)
            {
                for (int cols = 0; cols < this.Size; cols++)
                {
                    result.Append("[");
                    result.Append(this.Field[rows, cols]);
                    result.Append("]");
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private bool IsInFieldRange(int value)
        {
            if (value < 0 || value >= this.Size)
            {
                return false;
            }

            return true;
        }

        private bool IsNextCellFree(int nextRow, int nextCol)
        {
            if (this.Field[nextRow, nextCol] == 0)
            {
                return true;
            }

            return false;
        }
    }
}
