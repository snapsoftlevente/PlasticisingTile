using System.Linq.Expressions;
using PlasticisingTile.Core.BusinessObjects;
using PlasticisingTile.Core.Interfaces.Entities;

namespace PlasticisingTile.Core.Interfaces;
public interface IEntityServiceBase<TEntity, TBusinessObject>
    where TEntity : class, IEntity
    where TBusinessObject : class, IBusinessObject
{
    Task<TBusinessObject> CreateAsync(TBusinessObject entity, CancellationToken cancellationToken = default);
    IEnumerable<TBusinessObject> Get(Expression<Func<TEntity, bool>>? predicate = default);
    Task<TBusinessObject> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<TBusinessObject> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
