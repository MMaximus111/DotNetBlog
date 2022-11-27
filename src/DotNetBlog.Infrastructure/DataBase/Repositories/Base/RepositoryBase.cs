using DotNetBlog.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Infrastructure.DataBase.Repositories.Base;

public abstract class RepositoryBase<TEntity>
where TEntity : EntityBase
{
    private readonly BlogDbContext _dbContext;

    protected RepositoryBase(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
        Set = _dbContext.Set<TEntity>();
    }

    protected DbSet<TEntity> Set { get; }

    public virtual async Task<TEntity> GetAsync(Guid id)
    {
        TEntity entity = await _dbContext
            .Set<TEntity>()
            .FirstAsync(x => x.Id == id);

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
        Set.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        Set.Remove(entity);
    }

    public void Insert(TEntity entity)
    {
        Set.Add(entity);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}