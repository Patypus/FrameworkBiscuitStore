using MongoDB.Driver;

namespace Data.Context
{
    public interface IDataContext
    {
        IMongoDatabase GetDatabase();
    }
}