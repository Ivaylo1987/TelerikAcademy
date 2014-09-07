namespace ToyStore.DataGenerator
{
    using System;
    using ToyStore.Data;

    public class AgeRangeGenerator : DataGenerator
    {
        public AgeRangeGenerator(ToyStoreContext dbConnection, int count, RandomGenerator randomGenerator)
            : base(dbConnection, count, randomGenerator)
        {
        }

        public override void Generate()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var ageRange = new AgeRanx();

                ageRange.FromAge = this.RandomGenerator.GetInt(1, 6);
                ageRange.ToAge = this.RandomGenerator.GetInt(3, 20);

                this.Db.AgeRanges.Add(ageRange);

                if (i % 100 == 0)
                {
                    this.Db.SaveChanges();
                    Console.WriteLine(i);
                }
            }

            this.Db.SaveChanges();
        }
    }
}
