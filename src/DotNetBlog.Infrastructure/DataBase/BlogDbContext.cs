using DotNetBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Infrastructure.DataBase;

public class BlogDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public DbSet<Article>? Articles { get; set; }

    public DbSet<ArticleTopic>? ArticleTopics { get; set; }
}