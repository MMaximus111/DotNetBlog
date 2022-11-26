namespace DotNetBlog.Domain.Entities.Base;

public abstract class EntityBase
{
    protected EntityBase(Guid id)
    {
        Id = id;
        CreatedOn = DateTime.Now;
    }

    public Guid Id { get; }

    public DateTime CreatedOn { get; protected set; }
}