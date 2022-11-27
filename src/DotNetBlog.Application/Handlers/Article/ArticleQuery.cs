using System.Text.Json.Serialization;
using DotNetBlog.Application.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticleQuery : QueryBase<ArticleDto>
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; }
}