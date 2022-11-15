using System.Linq.Expressions;
using PlasticisingTile.Core.Interfaces.Entities;

namespace PlasticisingTile.Core.Interfaces;
public interface IRepository<T> where T : class, IEntity
{
    void Add(T entity);
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    void AddRange(IEnumerable<T> entitiesToAdd);
    Task AddRangeAsync(IEnumerable<T> entitiesToAdd, CancellationToken cancellationToken = default);
    T? GetById(Guid id);
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    IEnumerable<T> GetAll();
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    IQueryable<T> Query(Expression<Func<T, bool>>? predicate = default);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entitiesToRemove);
    void Update(T entity);
}
