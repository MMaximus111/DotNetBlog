using DotNetBlog.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings.Base;

public abstract class MapBase<TEntity> : IEntityTypeConfiguration<TEntity>
where TEntity : EntityBase
{
    private readonly string _tableName;

    protected MapBase(string tableName)
    {
        _tableName = tableName;
    }

    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(_tableName);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.CreatedOn).HasColumnName("created_on");

        ConfigureMap(builder);
    }

    protected abstract void ConfigureMap(EntityTypeBuilder<TEntity> builder);
}