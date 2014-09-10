namespace SortingHomework
{
    using System;

    public class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random random;

        private RandomGenerator()
        {
            this.random = new Random();
        }

        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }

            return instance;
        }

        public int GetRandomInt(int start, int end)
        {
            return this.random.Next(start, end);
        }
    }
}
