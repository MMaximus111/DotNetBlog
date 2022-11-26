using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings;

public class ArticleTopicMap : MapBase<ArticleTopic>
{
    public ArticleTopicMap()
        : base("article_topic")
    {
    }

    protected override void ConfigureMap(EntityTypeBuilder<ArticleTopic> builder)
    {
        builder.Property(x => x.Name).HasColumnName("name");
    }
}