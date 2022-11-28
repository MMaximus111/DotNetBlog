using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class ArticleTopic : EntityBase
{
    public ArticleTopic(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    protected ArticleTopic()
    {
    }

    public string Name { get; protected set; }
}