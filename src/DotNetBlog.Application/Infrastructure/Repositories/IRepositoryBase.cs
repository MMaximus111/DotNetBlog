using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Application.Infrastructure.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task<TEntity> GetAsync(Guid id);

    Task<IReadOnlyCollection<TEntity>> GetAllAsync(CancellationToken cancellationToken);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    void Insert(TEntity entity);

    Task SaveChangesAsync(CancellationToken cancellationToken);
}