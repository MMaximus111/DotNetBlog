using DotNetBlog.Application.Handlers.Base;
using DotNetBlog.Application.TransferObjects;

namespace DotNetBlog.Application.Handlers.News;

public class NewsQueryHandler : QueryHandlerBase<NewsQuery, PagedResultDto<NewsDto>>
{

    protected override Task<PagedResultDto<NewsDto>> QueryAsync(NewsQuery request, CancellationToken cancellationToken)
    {
        ArticleDto[] articles = new[]
        {
            new ArticleDto()
            {
                Description = "November has been a busy time for the .NET MAUI Community toolkit with multiple releases featuring a ton of amazing new features (not to mention a long list of bug fixes). The latest releases have new Views, Layouts, Tizen support, .NET 7 support and so much more. This post will get you up to speed on all the new features.",
                Title = ".NET 7 in depth",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "Let’s dive into some of the big new features in the latest .NET MAUI Community Toolkit releases.",
                Title = "Blazor features",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "The Expander view is a container control that provides a way to expand and collapse visual content when tapping a header. The control comprises of two sections, the header and content. The content is shown or hidden by tapping the Expander.Header or by setting the IsExpanded bindable property.",
                Title = "async/await in depth",
                AuthorName = "Maxim Usatenko",
            },
            new ArticleDto()
            {
                Description = "November has been a busy time for the .NET MAUI Community toolkit with multiple releases featuring a ton of amazing new features (not to mention a long list of bug fixes). The latest releases have new Views, Layouts, Tizen support, .NET 7 support and so much more. This post will get you up to speed on all the new features.",
                Title = ".NET 7 in depth",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "Let’s dive into some of the big new features in the latest .NET MAUI Community Toolkit releases.",
                Title = "Blazor features",
                AuthorName = "Milan Jovanovic",
            },
            new ArticleDto()
            {
                Description = "The Expander view is a container control that provides a way to expand and collapse visual content when tapping a header. The control comprises of two sections, the header and content. The content is shown or hidden by tapping the Expander.Header or by setting the IsExpanded bindable property.",
                Title = "async/await in depth",
                AuthorName = "Maxim Usatenko",
            }
        };

        return null;
        //return new PagedResultDto<NewsDto>(articles, request.Skip, request.Take);
    }
}