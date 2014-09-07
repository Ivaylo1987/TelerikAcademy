namespace ToyStore.DataGenerator
{
    using System;

    public class RandomGenerator
    {
        //private const string allAlphaNumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        //private const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
        //private const string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //private const string numerics = "1234567890";

        private const string allLeters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static RandomGenerator instance;

        private readonly Random random;

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

        public string GetStringExact(int length, string charsToUse = allLeters)
        {
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = charsToUse[this.random.Next(0, charsToUse.Length)];
            }

            return new string(result);
        }

        public string GetString(int min, int max, string charsToUse = allLeters)
        {
            return this.GetStringExact(this.random.Next(min, max + 1), charsToUse);
        }

        public int GetInt(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public double GetDouble(int seed)
        {
            return this.random.NextDouble() * seed;
        }

        public bool GetChance(int percent)
        {
            return this.random.Next(0, 101) <= percent;
        }

        public DateTime GetRandomDate()
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
}
