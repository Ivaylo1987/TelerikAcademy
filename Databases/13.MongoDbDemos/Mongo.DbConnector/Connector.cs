namespace Mongo.DbConnector
{
    using MongoDB.Driver;

    public class Connector
    {
        public  MongoDatabase GetDatabase (string connectionString, string databaseName)
        {
            var db = new MongoClient(connectionString);
            var server = db.GetServer();
            var database = server.GetDatabase(databaseName);

            return database;
        }
    }
}
