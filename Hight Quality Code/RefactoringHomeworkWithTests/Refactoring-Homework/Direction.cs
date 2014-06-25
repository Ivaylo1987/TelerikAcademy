namespace MatrixWalk
{
    using System;
    using System.Collections.Generic;

    public class Direction : IDirection
    {
        public Direction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public override string ToString()
        {
            return this.X + " " + this.Y;
        }
    }
}
