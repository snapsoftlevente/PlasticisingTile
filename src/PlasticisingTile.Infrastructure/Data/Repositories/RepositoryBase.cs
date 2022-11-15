using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PlasticisingTile.Core.Interfaces;
using PlasticisingTile.Core.Interfaces.Entities;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public abstract class RepositoryBase<TDbContext, TEntity> : IRepository<TEntity>
    where TDbContext : DbContext
    where TEntity : class, IEntity
{
    protected readonly TDbContext _context;
    protected DbSet<TEntity> _entities;

    public RepositoryBase(TDbContext context)
    {
        _context = context;
        _entities = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _entities.Add(entity);
        _context.SaveChanges();
    }

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        await _entities.AddAsync(entity, cancellationToken);
        _context.SaveChanges();
    }

    public void AddRange(IEnumerable<TEntity> entitiesToAdd)
    {
        if (entitiesToAdd == null)
        {
            throw new ArgumentNullException(nameof(entitiesToAdd));
        }

        _entities.AddRange(entitiesToAdd);
        _context.SaveChanges();
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entitiesToAdd, CancellationToken cancellationToken = default)
    {
        if (entitiesToAdd == null)
        {
            throw new ArgumentNullException(nameof(entitiesToAdd));
        }

        await _entities.AddRangeAsync(entitiesToAdd, cancellationToken);
        _context.SaveChanges();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _entities.ToList();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _entities.ToListAsync(cancellationToken);
    }

    public TEntity? GetById(Guid id)
    {
        return _entities.Find(id);
    }

    public async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _entities.FindAsync(id, cancellationToken);
    }

    public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = default)
    {
        var query = _entities.AsQueryable();

        if (predicate != default)
        {
            query = query.Where(predicate);
        }

        return query;
    }

    public void Remove(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _entities.Remove(entity);
        _context.SaveChanges();
    }

    public void RemoveRange(IEnumerable<TEntity> entitiesToRemove)
    {
        if (entitiesToRemove == null)
        {
            throw new ArgumentNullException(nameof(entitiesToRemove));
        }

        _entities.RemoveRange(entitiesToRemove);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _context.SaveChanges();
    }
}
