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
        ArticleDto[] articles = new[]
        {
            new ArticleDto()
            {
                Description = "All features in 1 article",
                Title = ".NET 7 in depth",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "All features in 1 article",
                Title = ".NET 7 in depth",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "All features in 1 article",
                Title = ".NET 7 in depth",
                AuthorName = "Milan Jovanovic",
            }
        };

        return new PagedResultDto<ArticleDto>(articles, request.Skip, request.Take);

        // IReadOnlyCollection<Domain.Entities.Article> articles = await _articleRepository.GetAllAsync(
        //     request.Skip,
        //     request.Take,
        //     request.AuthorId,
        //     cancellationToken);
        //
        // IReadOnlyCollection<ArticleDto> dtos = articles.Adapt<IReadOnlyCollection<ArticleDto>>();
        //
        // return new PagedResultDto<ArticleDto>(dtos, request.Skip, request.Take);
    }
}