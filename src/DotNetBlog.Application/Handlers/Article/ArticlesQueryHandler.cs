using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.Infrastructure.Repositories;
using DotNetBlog.Application.TransferObjects;
using Mapster;

namespace DotNetBlog.Application.Handlers.Article;

public class ArticlesQueryHandler : QueryHandlerBase<ArticlesQuery, PagedResultDto<ArticleDto>>
{
    private readonly IArticleRepository _articleRepository;

    public ArticlesQueryHandler(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    protected override async Task<PagedResultDto<ArticleDto>> QueryAsync(ArticlesQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<Domain.Entities.Article> articles = await _articleRepository.GetAllAsync(request.Skip, request.Take, cancellationToken);

        ArticleDto[] articleDtos = articles.Select(x => x.Adapt<ArticleDto>()).ToArray();

        return new PagedResultDto<ArticleDto>(articleDtos, request.Skip, request.Take);
    }
}