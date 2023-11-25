using James.Blogs.Repositories.Mongo.Entities;
using James.Blogs.Repository.MongoInfrastructure;
using James.Blogs.Repository.Repository.Mongo;

namespace James.Blogs.Repository;

public class MGPostRepository : MGBaseRepository<MGPostModel>, IPostRepository
{
    public MGPostRepository(IMongoDb database) : base(database) { }

}
