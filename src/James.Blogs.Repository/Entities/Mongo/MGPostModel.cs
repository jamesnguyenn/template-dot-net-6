using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using James.Blogs.Repository;

namespace James.Blogs.Repositories.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public class MGPostModel : TrackableEntity
    {
        public ObjectId Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? Status { get; set; }
        public List<int>? Tag { get; set; }
    }
}

