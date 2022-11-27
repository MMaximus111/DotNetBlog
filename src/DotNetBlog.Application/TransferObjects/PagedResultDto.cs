using System.Text.Json.Serialization;

namespace DotNetBlog.Application.TransferObjects;

public sealed class PagedResultDto<T>
{
    public PagedResultDto(IReadOnlyCollection<T> items, int skip, int take)
    {
        Data = items ?? throw new ArgumentNullException(nameof(items));

        Pagination = new PagingInfoDto
        {
            Skip = skip,
            Take = take,
            Returned = items.Count
        };
    }

    public static PagedResultDto<T> Empty { get; } = new PagedResultDto<T>(Array.Empty<T>(), 0, 0);

    [JsonPropertyName("data")]
    public IReadOnlyCollection<T> Data { get; }

    [JsonPropertyName("pagination")]
    public PagingInfoDto Pagination { get; }

    public sealed class PagingInfoDto
    {
        [JsonPropertyName("returned")]
        public int Returned { get; set; }

        [JsonPropertyName("skip")]
        public int Skip { get; set; }

        [JsonPropertyName("take")]
        public int Take { get; set; }
    }
}