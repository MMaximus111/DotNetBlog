using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed record ArticleDto
{
    [JsonPropertyName("title")]
    public string Title { get; init; } = default!;

    [JsonPropertyName("content")]
    public byte[] Content { get; init; } = default!;

    [JsonPropertyName("author_id")]
    public Guid AuthorId { get; init; }

    [JsonPropertyName("author_name")]
    public string AuthorName { get; init; } = default!;

    [JsonPropertyName("article_topics")]
    public IReadOnlyCollection<string> ArticleTopics { get; init; } = default!;
}