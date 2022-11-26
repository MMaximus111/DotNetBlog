using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class Article : EntityBase
{
    public Article(
        Guid id,
        Guid authorId,
        string title,
        byte[] content,
        ArticleTopic[] articleTopics)
        : base(id)
    {
        AuthorId = authorId;
        Title = title;
        Content = content;
        ArticleTopics = articleTopics;
    }

    public string Title { get; protected set; }

    public byte[] Content { get; protected set; }

    public Guid AuthorId { get; protected set; }

    public virtual User Author { get; protected set; }

    public virtual ICollection<ArticleTopic> ArticleTopics { get; protected set; }
}