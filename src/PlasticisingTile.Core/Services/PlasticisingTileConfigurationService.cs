using AutoMapper;
using PlasticisingTile.Core.BusinessObjects;
using PlasticisingTile.Core.Entities.ConfigurationData;
using PlasticisingTile.Core.Interfaces;

namespace PlasticisingTile.Core.Services;
public class PlasticisingTileConfigurationService : EntityServiceBase<NewTile, PlasticisingTileConfigurationBo>, IPlasticisingTileConfigurationService
{
    private readonly IDatasourceService _datasourceService;

    public PlasticisingTileConfigurationService(
        IRepository<NewTile> repository, 
        IMapper mapper,
        IDatasourceService datasourceService) 
        : base(repository, mapper)
    {
        _datasourceService = datasourceService;
    }

    public async Task<PlasticisingTileConfigurationBo> GetPlasticisingTileConfigurationAsync(Guid? id = null)
    {
        // TODO: implement business logic to select datasource
        // For now, the id 0 is hard-wired to fetch the only datasource record stored in the table
        var dataSource = await _datasourceService.GetByIdAsync(0);
        var plasticisingTileConfiguration = _mapper.Map<PlasticisingTileConfigurationBo>(dataSource);

        return plasticisingTileConfiguration;
    }
}
