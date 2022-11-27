using DotNetBlog.Application.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticlesQuery : QueryBase<PagedResultDto<ArticleDto>>
{
    public ArticlesQuery(int skip, int take, Guid? authorId = null)
    {
        Skip = skip;
        Take = take;
        AuthorId = authorId;
    }

    public int Skip { get; }

    public int Take { get; }

    public Guid? AuthorId { get; }
}