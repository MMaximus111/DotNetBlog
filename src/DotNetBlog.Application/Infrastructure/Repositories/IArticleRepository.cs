using DotNetBlog.Domain.Entities;

namespace DotNetBlog.Application.Infrastructure.Repositories;

public interface IArticleRepository : IRepositoryBase<Article>
{
    Task<IReadOnlyCollection<Article>> GetAllAsync(
        int skip = 0,
        int take = int.MaxValue,
        Guid? authorId = null,
        CancellationToken cancellationToken = default);
}