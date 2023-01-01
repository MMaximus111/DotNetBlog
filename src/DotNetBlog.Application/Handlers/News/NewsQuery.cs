using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.News;

public class NewsQuery : QueryBase<PagedResultDto<NewsDto>>
{
    public NewsQuery(int skip, int take)
    {
        Skip = skip;
        Take = take;
    }

    public int Skip { get; }

    public int Take { get; }
}