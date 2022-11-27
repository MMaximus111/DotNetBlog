using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.Infrastructure.Repositories;
using DotNetBlog.Application.TransferObjects;
using Mapster;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticleQueryHandler : QueryHandlerBase<ArticleQuery, ArticleDto>
{
    private readonly IArticleRepository _articleRepository;

    public ArticleQueryHandler(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    protected override async Task<ArticleDto> QueryAsync(ArticleQuery request, CancellationToken cancellationToken)
    {
        Domain.Entities.Article article = await _articleRepository.GetAsync(request.Id);

        return article.Adapt<ArticleDto>();
    }
}