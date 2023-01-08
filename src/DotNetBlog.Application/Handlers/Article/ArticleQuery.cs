using System.Text.Json.Serialization;
using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticleQuery : QueryBase<ArticleDto>
{
    public ArticleQuery(Guid id)
    {
        Id = id;
    }

    [JsonPropertyName("id")]
    public Guid Id { get; init; }
}