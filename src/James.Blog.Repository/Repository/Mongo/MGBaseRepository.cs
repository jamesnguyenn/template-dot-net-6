using MongoDB.Driver;

namespace James.Blog.Repository.Repository.Mongo;

public abstract class MGBaseRepository<T> : IMGBaseRepository<T>
{
    private readonly IMongoCollection<T> _collection;
}
