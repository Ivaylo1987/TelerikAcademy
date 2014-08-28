namespace Northwind.Actions
{
    using System.Data.Entity;
    public class DataAccessObject
    {
        private DbContext dbContext;

        public DataAccessObject(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
