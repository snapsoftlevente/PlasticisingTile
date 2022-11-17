using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Entities.ConfigurationData;
using PlasticisingTile.Core.Enums;
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

    // TODO: refactor method
    public async Task<PlasticisingTileBo> GetPlasticisingTileAsync(PlasticisingTileConfigureRequestBo plasticisingTileConfiguration)
    {
        var dataSource = await GetDatasourceAsync();

        if (dataSource == null || dataSource.Realm == null || dataSource.TableOrStoreName == null || dataSource.TimestampColumnName == null)
        {
            throw new ArgumentException("Datasource configuration is not valid");
        }

        if (!VerifyColumns(plasticisingTileConfiguration, dataSource.DatasourceColumns))
        {
            throw new ArgumentException("At least one of the columns provided is not valid");
        }

        // TODO: refactor as mapping (Datasource & PlasticisingTileConfigureRequestBo => DynamicQuery)
        var dynamicQuery = new DynamicQuery(dataSource.TableOrStoreName)
        {
            ProjectionAttributeKeys = plasticisingTileConfiguration.SelectedColumnKeys
        };

        if (plasticisingTileConfiguration.DateTimeRangeFilter?.DateTimeFrom != null)
        {
            dynamicQuery.Selections = dynamicQuery.Selections.Append(new DynamicQuerySelection(dataSource.TimestampColumnName)
            {
                SelectionOperation = SelectionOperationEnum.GreaterThanOrEqual,
                OperationValue = plasticisingTileConfiguration.DateTimeRangeFilter.DateTimeFrom.Value.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss'.'fff")
            });
        }

        if (plasticisingTileConfiguration.DateTimeRangeFilter?.DateTimeTo != null)
        {
            dynamicQuery.Selections = dynamicQuery.Selections.Append(new DynamicQuerySelection(dataSource.TimestampColumnName)
            {
                SelectionOperation = SelectionOperationEnum.LessThanOrEqual,
                OperationValue = plasticisingTileConfiguration.DateTimeRangeFilter.DateTimeTo.Value.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss'.'fff")
            });
        }

        IEnumerable<dynamic> resultSet;
        using (var historicalDataRepository = _dynamicRepositoryFactory.Create(dataSource.Realm))
        {
            resultSet = await historicalDataRepository.QueryAsync(dynamicQuery);
        }

        // TODO: refactor as mapping (IEnumerable<dynamic> & PlasticisingTileConfigureRequestBo => PlasticisingTileBo)
        var datapoints = plasticisingTileConfiguration.SelectedColumnKeys.ToDictionary(
            k => k, 
            k=> resultSet.Select(r => double.Parse(((IDictionary<string, object>)r)[k].ToString()!))
        );

        var result = new PlasticisingTileBo
        {
            Series = plasticisingTileConfiguration.SelectedAggregations.Select(a => new PlasticisingSerieBo
            {
                Name = a.ToString(),
                DataPoints = plasticisingTileConfiguration.SelectedColumnKeys.Select(k => a switch
                {
                    PlasticisingTileAggregationEnum.Average => datapoints[k].Any() ? datapoints[k].Average() : 0.0,
                    PlasticisingTileAggregationEnum.Minimum => datapoints[k].Any() ? datapoints[k].Min() : 0.0,
                    PlasticisingTileAggregationEnum.Maximum => datapoints[k].Any() ? datapoints[k].Max() : 0.0,
                    _ => throw new NotImplementedException()
                })
            })
        };

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
