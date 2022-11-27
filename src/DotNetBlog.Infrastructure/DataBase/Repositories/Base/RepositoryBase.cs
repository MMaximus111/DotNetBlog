using DotNetBlog.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Infrastructure.DataBase.Repositories.Base;

public abstract class RepositoryBase<TEntity>
where TEntity : EntityBase
{
    private readonly BlogDbContext _dbContext;
    private readonly DbSet<TEntity> _set;

    protected RepositoryBase(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
        _set = _dbContext.Set<TEntity>();
    }

    public virtual async Task<TEntity> GetAsync(Guid id)
    {
        TEntity entity = await _dbContext
            .Set<TEntity>()
            .FirstAsync();

        return entity;
    }

    public virtual async Task<IReadOnlyCollection<TEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        TEntity[] entities = await _dbContext
            .Set<TEntity>()
            .ToArrayAsync(cancellationToken);

        return entities;
    }

    public void Update(TEntity entity)
    {
        _set.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        _set.Remove(entity);
    }

    public void Insert(TEntity entity)
    {
        _set.Add(entity);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}