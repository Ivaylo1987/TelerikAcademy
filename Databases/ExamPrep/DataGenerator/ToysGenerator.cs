namespace ToyStore.DataGenerator
{
    using ToyStore.Data;
    using System.Linq;
    using System;

    public class ToysGenerator : DataGenerator
    {
        public ToysGenerator(ToyStoreContext dbConnection, int count, RandomGenerator randomGenerator)
            : base(dbConnection, count, randomGenerator)
        {
        }

        public override void Generate()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var toy = new Toy();
                toy.Color = this.RandomGenerator.GetChance(20) ? null : this.RandomGenerator.GetString(3, 15);
                toy.Type = this.RandomGenerator.GetChance(20) ? null : this.RandomGenerator.GetString(3, 15);
                toy.Name = this.RandomGenerator.GetString(5, 15);
                toy.Price = (decimal)this.RandomGenerator.GetDouble(50);

                var manifacturersId = this.Db.Manifacturers.Select(m => m.Id).ToArray();
                var index = this.RandomGenerator.GetInt(0, manifacturersId.Length - 1);
                toy.ManifacturerId = manifacturersId[index];

                var ageRangGesId = this.Db.AgeRanges.Select(r=> r.Id).ToArray();
                index = this.RandomGenerator.GetInt(0, ageRangGesId.Length - 1);
                toy.AgeRangeId = ageRangGesId[index];

                var categoriesIds = this.Db.Categories.Select(c => c.Id).ToArray();
                index = this.RandomGenerator.GetInt(0, categoriesIds.Length - 1);
                var currentCategory = this.Db.Categories.Find(categoriesIds[index]);

                toy.Categories.Add(currentCategory);

                this.Db.Toys.Add(toy);

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
