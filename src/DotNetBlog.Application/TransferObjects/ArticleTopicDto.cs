using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed record ArticleTopicDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; } = default!;
}