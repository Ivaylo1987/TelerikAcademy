namespace ToyStore.ConsoleClient
{
    using ToyStore.Data;
    using ToyStore.DataGenerator;


    class EntryPoint
    {
        static void Main()
        {
            var dbConnection = new ToyStoreContext();
            var random = RandomGenerator.GetInstance();

            dbConnection.Configuration.AutoDetectChangesEnabled = false;

            var categoriesGenerator = new CategoriesGenerator(dbConnection, 100, random);
            categoriesGenerator.Generate();

            var ageRangeGenerator = new AgeRangeGenerator(dbConnection, 100, random);
            ageRangeGenerator.Generate();

            var manifacturerGenerator = new ManifacturersGenerator(dbConnection, 1000, random);
            manifacturerGenerator.Generate();

            var toysGenerator = new ToysGenerator(dbConnection, 20000, random);
            toysGenerator.Generate();

        }
    }
}
