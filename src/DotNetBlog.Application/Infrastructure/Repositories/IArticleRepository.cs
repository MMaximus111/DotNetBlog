using DotNetBlog.Domain.Entities;

namespace DotNetBlog.Application.Infrastructure.Repositories;

public interface IArticleRepository : IRepositoryBase<Article>
{
    new Task<Article> GetAsync(Guid id);
}