namespace ToyStore.DataGenerator
{
    using System;
    using ToyStore.Data;

    public class ManifacturersGenerator : DataGenerator
    {
        public ManifacturersGenerator(ToyStoreContext dbConnection, int count, RandomGenerator randomGenerator)
            : base(dbConnection, count, randomGenerator)
        {
        }

        public override void Generate()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var manifacturer = new Manifacturer();
                manifacturer.Name = this.RandomGenerator.GetString(3, 10) + i;
                manifacturer.Country = this.RandomGenerator.GetString(3, 10);

                this.Db.Manifacturers.Add(manifacturer);

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
