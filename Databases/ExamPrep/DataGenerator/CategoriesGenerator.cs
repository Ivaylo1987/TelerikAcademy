namespace ToyStore.DataGenerator
{
    using System;
    using ToyStore.Data;

    public class CategoriesGenerator : DataGenerator
    {
        public CategoriesGenerator(ToyStoreContext dbConnection, int count, RandomGenerator randomGenerator)
            : base(dbConnection, count, randomGenerator)
        {
        }

        public override void Generate()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var category = new Category();
                category.Name = this.RandomGenerator.GetString(3, 20);

                this.Db.Categories.Add(category);

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
