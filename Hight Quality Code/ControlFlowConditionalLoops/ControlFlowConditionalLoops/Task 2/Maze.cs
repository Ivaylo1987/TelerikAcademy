namespace ControlFlowConditionalLoops
{
    public class Maze
    {
        public const int MIN_X = 1000;
        public const int MAX_X = 1000;
        public const int MIN_Y = 1000;
        public const int MAX_Y = 1800;
        private bool shouldVisitCell = true;

        public void MoveToCell(int x, int y)
        {
            if (this.CheckIfCellIsValid(x, y) && this.shouldVisitCell)
            {
                this.VisitCell(x, y);
            }
        }

        private bool CheckIfCellIsValid(int x, int y)
        {
            bool isValidX = MIN_X <= x && x <= MAX_X;
            bool isValidY = MIN_Y <= y && y <= MAX_Y;

            return isValidX && isValidY;
        }

        private void VisitCell(int x, int y)
        {
            // ...
        }
    }
}
