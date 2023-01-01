using DotNetBlog.Domain.Entities;
using DotNetBlog.Infrastructure.DataBase.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBlog.Infrastructure.DataBase.Mappings;

public class UserMap : MapBase<User>
{
    public UserMap()
    : base("users")
    {
    }

    protected override void ConfigureMap(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Name).HasColumnName("name");
        builder.Property(x => x.Email).HasColumnName("email");
        builder.Property(x => x.HashedPassword).HasColumnName("hashed_password");
        builder.Property(x => x.SubscribedOnEmails).HasColumnName("subscribed_on_emails");

         builder.HasMany(x => x.Articles).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
    }
}