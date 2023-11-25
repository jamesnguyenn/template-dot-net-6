using MongoDB.Driver;

namespace James.Blogs.Repository.IRepository.Mongo;

public interface IMGBaseRepository<T>
{
    Task AddEntity(T entity);
}
