using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class ArticleTopic : EntityBase
{
    protected ArticleTopic()
    {
    }

    public Guid ArticleId { get; protected set; }

    public Guid TopicId { get; protected set; }

    public virtual Article Article { get; protected set; }
}