using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class ArticleTopic : EntityBase
{
    public ArticleTopic(Guid id, string name)
        : base(id)
    {
        Name = name;
    }

    public string Name { get; protected set; }
}