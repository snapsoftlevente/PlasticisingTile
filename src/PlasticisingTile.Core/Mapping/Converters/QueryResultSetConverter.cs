using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.Enums;

namespace PlasticisingTile.Core.Mapping.Converters;
internal class QueryResultSetConverter : ITypeConverter<IEnumerable<IDictionary<string, double>>, PlasticisingTileBo>
{
    public PlasticisingTileBo Convert(IEnumerable<IDictionary<string, double>> resultSet, PlasticisingTileBo plasticisingTile, ResolutionContext context)
    {
        if (!context.Items.TryGetValue(nameof(PlasticisingTileConfigureRequestBo), out var plasticisingTileConfigureRequestObject)
            || plasticisingTileConfigureRequestObject is not PlasticisingTileConfigureRequestBo plasticisingTileConfigureRequest)
        {
            throw new ArgumentNullException(nameof(PlasticisingTileConfigureRequestBo));
        }
        else if (plasticisingTileConfigureRequest.SelectedColumnKeys == null)
        {
            throw new ArgumentNullException(nameof(PlasticisingTileConfigureRequestBo.SelectedColumnKeys));
        }

        plasticisingTile ??= new PlasticisingTileBo();

        var datapoints = plasticisingTileConfigureRequest.SelectedColumnKeys.ToDictionary(
            k => k,
            k => resultSet.Select(r => r[k])
        );

        plasticisingTile.Series = plasticisingTileConfigureRequest.SelectedAggregations.Select(a => new PlasticisingSerieBo
        {
            Name = a.ToString(),
            DataPoints = plasticisingTileConfigureRequest.SelectedColumnKeys.Select(k => a switch
            {
                PlasticisingTileAggregationEnum.Average => datapoints[k].Any() ? datapoints[k].Average() : 0.0,
                PlasticisingTileAggregationEnum.Minimum => datapoints[k].Any() ? datapoints[k].Min() : 0.0,
                PlasticisingTileAggregationEnum.Maximum => datapoints[k].Any() ? datapoints[k].Max() : 0.0,
                _ => throw new NotImplementedException()
            })
        });

        return plasticisingTile;
    }
}
