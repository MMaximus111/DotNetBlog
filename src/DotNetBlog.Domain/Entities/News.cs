using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class News : EntityBase
{
    protected News()
    {
    }

    public string Title { get; protected set; } = default!;

    public string Content { get; protected set; } = default!;
}