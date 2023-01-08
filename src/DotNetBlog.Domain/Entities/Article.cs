using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class Article : EntityBase
{
    public Article(
        Guid id,
        Guid authorId,
        string title,
        string description,
        byte minutesToRead,
        string content,
        ArticleTopic[] articleTopics)
    {
        Id = id;
        AuthorId = authorId;
        Title = title;
        Content = content;
        MinutesToRead = minutesToRead;
        ArticleTopics = articleTopics;
        Description = description;
    }

    protected Article()
    {
    }

    public string Title { get; protected set; }

    public string Description { get; protected set; }

    public byte MinutesToRead { get; protected set; }

    public string Content { get; protected set; }

    public Guid AuthorId { get; protected set; }

    public virtual User Author { get; protected set; }

    public virtual ICollection<ArticleTopic> ArticleTopics { get; protected set; }
}