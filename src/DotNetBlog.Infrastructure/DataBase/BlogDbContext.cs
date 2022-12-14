using DotNetBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Infrastructure.DataBase;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<User>? Users { get; set; }

    public DbSet<News>? News { get; set; }

    public DbSet<Article>? Articles { get; set; }

    public DbSet<ArticleTopic>? ArticleTopics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureAssemblyMarker).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}