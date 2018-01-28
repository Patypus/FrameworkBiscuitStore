using MongoDB.Driver;

namespace Data.Context
{
    public class DataContext : IDataContext
    {
        private readonly string _connectionString;
        private readonly string _databaseName;

        private IMongoDatabase _database; 

        public DataContext(string connectionString, string databaseName)
        {
            _connectionString = connectionString;
            _databaseName = databaseName;
        }

        public IMongoDatabase GetDatabase()
        {
            if (_database != null)
            {
                var client = new MongoClient(_connectionString);
                _database = client.GetDatabase(_databaseName);
            }

            return _database;
        }
    }
}