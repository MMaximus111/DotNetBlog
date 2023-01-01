using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed record NewsDto
{
    [JsonPropertyName("title")]
    public string Title { get; init; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = default!;
}