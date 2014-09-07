namespace ToyStore.DataGenerator
{
    using ToyStore.Data;
    public abstract class DataGenerator
    {
        private RandomGenerator randomGenerator;
        private int count;
        private ToyStoreContext db;

        protected DataGenerator(ToyStoreContext dbConnection, int count, RandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
            this.count = count;
            this.db = dbConnection;
        }

        public RandomGenerator RandomGenerator
        {
            get
            {
                return this.randomGenerator;
            }
        }

        public int Count { get { return this.count; } }
        public ToyStoreContext Db { get { return this.db; } }

        public abstract void Generate();
    }
}
