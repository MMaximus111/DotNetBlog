using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed record NewsDto
{
    [JsonPropertyName("title")]
    public string Title { get; init; } = default!;

    [JsonPropertyName("content")]
    public string Content { get; init; } = default!;

    [JsonPropertyName("created_on")]
    public DateTime CreatedOn { get; init; } = default!;
}