using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Entities.ConfigurationData;
using PlasticisingTile.Core.Interfaces.Repository;
using PlasticisingTile.Core.Interfaces.Services;

namespace PlasticisingTile.Core.Services;
public class DatasourceService : EntityServiceBase<Datasource, DatasourceBo>, IDatasourceService
{
    public DatasourceService(IRepository<Datasource> repository, IMapper mapper) : base(repository, mapper)
    {
    }

    public override Task<DatasourceBo> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var entity = _repository
            .Query(predicate: ds => ds.Id == id, ds => ds.Connection, ds => ds.DatasourceColumns)
            .Single();

        var businessObject = _mapper.Map<DatasourceBo>(entity);

        return Task.FromResult(businessObject);
    }
}
