using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings;

public class NewsMap : MapBase<News>
{
    public NewsMap()
        : base("news")
    {
    }

    protected override void ConfigureMap(EntityTypeBuilder<News> builder)
    {
        builder.Property(x => x.Title).HasColumnName("title");
        builder.Property(x => x.Content).HasColumnName("content");
    }
}