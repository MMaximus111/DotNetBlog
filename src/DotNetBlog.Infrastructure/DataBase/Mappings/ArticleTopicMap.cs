using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings;

public class ArticleTopicMap : MapBase<ArticleTopic>
{
    public ArticleTopicMap()
        : base("article_topics")
    {
    }

    protected override void ConfigureMap(EntityTypeBuilder<ArticleTopic> builder)
    {
        builder.Property(x => x.ArticleId).HasColumnName("id_article");
        builder.Property(x => x.TopicId).HasColumnName("id_topic");

        builder.HasOne(x => x.Article).WithMany(x => x.ArticleTopics).HasForeignKey(x => x.ArticleId);
    }
}