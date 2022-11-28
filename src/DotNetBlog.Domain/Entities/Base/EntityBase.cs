namespace DotNetBlog.Domain.Entities.Base;

public abstract class EntityBase
{
    protected EntityBase()
    {
        CreatedOn = DateTime.Now;
    }

    public Guid Id { get; protected set; }

    public DateTime CreatedOn { get; protected set; }
}