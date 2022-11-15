using PlasticisingTile.Core.BusinessObjects;
using PlasticisingTile.Core.Interfaces.Entities;
using PlasticisingTile.Core.Interfaces;
using AutoMapper;
using System.Linq.Expressions;

namespace PlasticisingTile.Core.Services;

public abstract class EntityServiceBase<TEntity, TBusinessObject> : IEntityServiceBase<TEntity, TBusinessObject>
    where TEntity : class, IEntity
    where TBusinessObject : class, IBusinessObject
{
    protected readonly IRepository<TEntity> _repository;
    protected readonly IMapper _mapper;

    public EntityServiceBase(IRepository<TEntity> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public virtual async Task<TBusinessObject> CreateAsync(TBusinessObject businessObject, CancellationToken cancellationToken = default)
    {
        var entity = _mapper.Map<TEntity>(businessObject);

        await _repository.AddAsync(entity, cancellationToken);

        return _mapper.Map<TBusinessObject>(entity);
    }

    public virtual IEnumerable<TBusinessObject> Get(Expression<Func<TEntity, bool>>? predicate = default)
    {
        var entities = _repository.Query(predicate).ToList();
        var businessObjects = _mapper.Map<IEnumerable<TBusinessObject>>(entities);

        return businessObjects;
    }

    public virtual async Task<TBusinessObject> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        var businessObject = _mapper.Map<TBusinessObject>(entity);

        return businessObject;
    }
}
