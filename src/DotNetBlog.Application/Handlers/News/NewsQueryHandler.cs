using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.Infrastructure.Repositories;
using DotNetBlog.Application.TransferObjects;
using Mapster;

namespace DotNetBlog.Application.Handlers.News;

public class NewsQueryHandler : QueryHandlerBase<NewsQuery, PagedResultDto<NewsDto>>
{
    private readonly INewsRepository _newsRepository;

    public NewsQueryHandler(INewsRepository newsRepository)
    {
        _newsRepository = newsRepository;
    }

    protected override async Task<PagedResultDto<NewsDto>> QueryAsync(NewsQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<Domain.Entities.News> news = await _newsRepository.GetAllAsync(request.Skip, request.Take, cancellationToken);

        NewsDto[] newsDtos = news.Select(x => x.Adapt<NewsDto>()).ToArray();

        return new PagedResultDto<NewsDto>(newsDtos, request.Skip, request.Take);
    }
}