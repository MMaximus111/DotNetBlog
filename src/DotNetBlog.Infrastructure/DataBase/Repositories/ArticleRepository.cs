using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Infrastructure.DataBase.Repositories;

public class ArticleRepository : RepositoryBase<Article>
{
    public ArticleRepository(BlogDbContext dbContext)
        : base(dbContext)
    {
    }

    public override async Task<Article> GetAsync(Guid id)
    {
        Article article = await Set
            .AsQueryable()
            .Include(x => x.Author)
            .Include(x => x.ArticleTopics)
            .FirstAsync(x => x.Id == id);

        return article;
    }
}