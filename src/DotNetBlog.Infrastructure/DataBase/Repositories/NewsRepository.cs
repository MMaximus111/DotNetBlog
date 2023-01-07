using DotNetBlog.Application.Infrastructure.Repositories;
using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Repositories.Base;

namespace DotNetBlog.Infrastructure.DataBase.Repositories;

public class NewsRepository : RepositoryBase<News>, INewsRepository
{
    public NewsRepository(BlogDbContext dbContext)
        : base(dbContext)
    {
    }
}