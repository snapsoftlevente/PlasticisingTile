using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Models.DynamicQuery;

namespace PlasticisingTile.Core.Mapping.Converters;
internal class PlasticisingTileConfigureRequestConverter : ITypeConverter<PlasticisingTileConfigureRequestBo, DynamicQuery>
{
    public DynamicQuery Convert(PlasticisingTileConfigureRequestBo plasticisingTileConfiguration, DynamicQuery dynamicQuery, ResolutionContext context)
    {
        var dataSource = (DatasourceBo?)context.Items[nameof(DatasourceBo)];

        if (dataSource == null)
        {
            throw new ArgumentNullException(nameof(DatasourceBo));
        }
        else if (string.IsNullOrEmpty(dataSource.TableOrStoreName))
        {
            throw new ArgumentNullException(nameof(DatasourceBo.TableOrStoreName));
        }
        else if (string.IsNullOrEmpty(dataSource.TimestampColumnName))
        {
            throw new ArgumentNullException(nameof(DatasourceBo.TimestampColumnName));
        }

        dynamicQuery ??= context.Mapper.Map<DynamicQuery>(dataSource);

        dynamicQuery.ProjectionAttributeKeys = plasticisingTileConfiguration.SelectedColumnKeys;

        if (plasticisingTileConfiguration.DateTimeRangeFilter?.DateTimeFrom != null)
        {
            dynamicQuery.Selections = dynamicQuery.Selections.Append(new DynamicQuerySelection(dataSource.TimestampColumnName)
            {
                Operation = SelectionOperationEnum.GreaterThanOrEqual,
                RightOperandValue = plasticisingTileConfiguration.DateTimeRangeFilter.DateTimeFrom.Value
            });
        }

        if (plasticisingTileConfiguration.DateTimeRangeFilter?.DateTimeTo != null)
        {
            dynamicQuery.Selections = dynamicQuery.Selections.Append(new DynamicQuerySelection(dataSource.TimestampColumnName)
            {
                Operation = SelectionOperationEnum.LessThanOrEqual,
                RightOperandValue = plasticisingTileConfiguration.DateTimeRangeFilter.DateTimeTo.Value
            });
        }

        return dynamicQuery;
    }
}
