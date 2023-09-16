using System;
using MongoDB.Driver;

namespace James.Blog.Repository.MongoInfrastructure
{
    public interface IMongoDb
    {
        IMongoDatabase Db { get; }
    }
    public class MongoDb : IMongoDb
    {
        public MongoDb(IMongoDatabase db)
        {
            Db = db;
        }

        public IMongoDatabase Db { get; private set; }
    }
}

