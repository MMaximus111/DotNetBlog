using DotNetBlog.Application.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticlesQuery : QueryBase<PagedResultDto<ArticleDto>>
{
    public ArticlesQuery(int skip, int take)
    {
        Skip = skip;
        Take = take;
    }

    public int Skip { get; }

    public int Take { get; }
}