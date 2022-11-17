using System.Linq.Expressions;
using PlasticisingTile.Core.Interfaces.Entities;

namespace PlasticisingTile.Core.Interfaces.Repository;
public interface IRepository<TEntity> where TEntity : class, IEntity
{
    void Add(TEntity entity);
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    void AddRange(IEnumerable<TEntity> entitiesToAdd);
    Task AddRangeAsync(IEnumerable<TEntity> entitiesToAdd, CancellationToken cancellationToken = default);
    TEntity? GetById(int id);
    Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    TEntity? GetById(Guid id);
    Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    IEnumerable<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = default, params Expression<Func<TEntity, object>>[] includes);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entitiesToRemove);
    void Update(TEntity entity);
}
