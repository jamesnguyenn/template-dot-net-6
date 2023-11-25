using James.Blog.Repository.IRepository.Mongo;
using James.Blog.Repository.MongoInfrastructure;
using MongoDB.Driver;
namespace James.Blog.Repository.Repository.Mongo;

public abstract class MGBaseRepository<T> : IMGBaseRepository<T>
{

    private readonly IMongoCollection<T> _collection;

    protected MGBaseRepository(IMongoDb database)
    {
        _collection = database.Db.GetCollection<T>(typeof(T).Name);
    }

    public virtual Task AddEntity(T entity)
    {
        return _collection.InsertOneAsync(entity);
    }

}
