using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings;

public class ArticleMap : MapBase<Article>
{
    public ArticleMap()
        : base("article")
    {
    }

    protected override void ConfigureMap(EntityTypeBuilder<Article> builder)
    {
        builder.Property(x => x.AuthorId).HasColumnName("id_author");
        builder.Property(x => x.Title).HasColumnName("title");
        builder.Property(x => x.Content).HasColumnName("content");
        builder.Property(x => x.MinutesToRead).HasColumnName("minutes_to_read");
        builder.Property(x => x.Description).HasColumnName("description");

        builder.HasOne(x => x.Author).WithMany().HasForeignKey(x => x.AuthorId);
    }
}