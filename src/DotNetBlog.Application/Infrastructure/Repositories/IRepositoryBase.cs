using DotNetBlog.Domain.Entities.Base;

namespace DotNetBlog.Application.Infrastructure.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task<TEntity> GetAsync(Guid id);

    Task<IReadOnlyCollection<TEntity>> GetAllAsync(int skip = 0, int take = int.MaxValue, CancellationToken cancellationToken = default);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    void Insert(TEntity entity);

    Task SaveChangesAsync(CancellationToken cancellationToken);
}