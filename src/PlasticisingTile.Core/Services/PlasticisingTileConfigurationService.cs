using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Entities.ConfigurationData;
using PlasticisingTile.Core.Interfaces.Repository;
using PlasticisingTile.Core.Interfaces.Services;
using PlasticisingTile.Core.Models.DynamicQuery;

namespace PlasticisingTile.Core.Services;
public class PlasticisingTileConfigurationService : EntityServiceBase<NewTile, PlasticisingTileConfigurationBo>, IPlasticisingTileConfigurationService
{
    private readonly IDatasourceService _datasourceService;
    private readonly IDynamicRepositoryFactory _dynamicRepositoryFactory;

    public PlasticisingTileConfigurationService(
        IRepository<NewTile> repository, 
        IMapper mapper,
        IDatasourceService datasourceService,
        IDynamicRepositoryFactory dynamicRepositoryFactory) 
        : base(repository, mapper)
    {
        _datasourceService = datasourceService;
        _dynamicRepositoryFactory = dynamicRepositoryFactory;
    }

    public async Task<PlasticisingTileBo> GetPlasticisingTileAsync(PlasticisingTileConfigureRequestBo plasticisingTileConfigureRequest)
    {
        var dataSource = await GetDatasourceAsync();

        if (dataSource == null || dataSource.Realm == null || dataSource.TableOrStoreName == null || dataSource.TimestampColumnName == null)
        {
            throw new ArgumentException("Datasource configuration is not valid");
        }

        if (!VerifyColumns(plasticisingTileConfigureRequest, dataSource.DatasourceColumns))
        {
            throw new ArgumentException("At least one of the columns provided is not valid");
        }

        var dynamicQuery = _mapper.Map<DynamicQuery>(
            plasticisingTileConfigureRequest, 
            opt => opt.Items[nameof(DatasourceBo)] = dataSource);

        IEnumerable<IDictionary<string, double>> queryResult;
        using (var historicalDataRepository = _dynamicRepositoryFactory.Create(dataSource.Realm))
        {
            queryResult = await historicalDataRepository.QueryAsync<double>(dynamicQuery);
        }

        var result = _mapper.Map<PlasticisingTileBo>(
            queryResult,
            opt => opt.Items[nameof(PlasticisingTileConfigureRequestBo)] = plasticisingTileConfigureRequest);

        return result;
    }

    public async Task<PlasticisingTileConfigurationBo> GetPlasticisingTileConfigurationAsync(Guid? id = null)
    {
        var dataSource = await GetDatasourceAsync();
        var plasticisingTileConfiguration = _mapper.Map<PlasticisingTileConfigurationBo>(dataSource);

        return plasticisingTileConfiguration;
    }

    #region private methods

    private async Task<DatasourceBo> GetDatasourceAsync()
    {
        // TODO: implement business logic to select datasource
        // For now, the id 0 is hard-wired to fetch the only datasource record stored in the table
        return await _datasourceService.GetByIdAsync(0);
    }

    private bool VerifyColumns(PlasticisingTileConfigureRequestBo plasticisingTileConfiguration, IEnumerable<DatasourceColumnBo> availableColumns)
    {
        var unavailableColumns = plasticisingTileConfiguration.SelectedColumnKeys
            .Where(k => !availableColumns.Any(ac => ac.Key != null && ac.Key.Equals(k, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        return !unavailableColumns.Any();
    }

    #endregion
}
