using MongoDB.Driver;

namespace James.Blog.Repository.IRepository.Mongo;

public interface IMGBaseRepository<T>
{
    Task AddEntity(T entity);
}
