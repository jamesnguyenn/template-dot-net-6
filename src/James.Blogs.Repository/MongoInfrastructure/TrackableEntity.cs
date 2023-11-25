using System;
namespace James.Blogs.Repository;

public interface ITrackableEntity
{
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
    long CreatedBy { get; set; }
    long UpdatedBy { get; set; }
}
public class TrackableEntity : ITrackableEntity
{

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long CreatedBy { get; set; }

    public long UpdatedBy { get; set; }
}


