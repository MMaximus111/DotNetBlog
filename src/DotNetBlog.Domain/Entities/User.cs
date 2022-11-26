using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Domain.Entities;

public class User : EntityBase
{
    public User(
        Guid id,
        string name,
        string email,
        string hashedPassword,
        bool subscribedOnEmails)
        : base(id)
    {
        SubscribedOnEmails = subscribedOnEmails;
        Name = name;
        Email = email;
        HashedPassword = hashedPassword;
    }

    public string Email { get; protected set; }

    public string HashedPassword { get; protected set; }

    public string Name { get; protected set; }

    public bool SubscribedOnEmails { get; protected set; }

    public virtual ICollection<Article> Articles { get; protected set; }
}