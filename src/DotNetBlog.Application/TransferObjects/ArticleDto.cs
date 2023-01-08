using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed record ArticleDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; } = default!;

    [JsonPropertyName("title")]
    public string Title { get; init; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = default!;

    [JsonPropertyName("content")]
    public string Content { get; init; } = default!;

    [JsonPropertyName("minutes_to_read")]
    public byte MinutesToRead { get; init; }

    [JsonPropertyName("author_id")]
    public Guid AuthorId { get; init; }

    [JsonPropertyName("author_name")]
    public string AuthorName { get; init; } = default!;

    [JsonPropertyName("article_topics")]
    public IReadOnlyCollection<string> ArticleTopics { get; init; } = default!;
}