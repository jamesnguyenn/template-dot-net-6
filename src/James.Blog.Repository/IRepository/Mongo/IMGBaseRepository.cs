using MongoDB.Driver;

namespace James.Blog.Repository.IRepository.Mongo;

public interface IMGBaseRepository<T>
{
    public FilterDefinition<T> Filter { get; }
    Task AddEntity(T entity);
    Task Upsert(List<T> entities);
    Task AddManyAsync(List<T> entities);
}
