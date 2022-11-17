using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Enums;
using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Plasticising;

public class PlasticisingTileConfigurationBo : IBusinessObject
{
    public DateTimeRangeFilterBo? DateTimeRangeFilter { get; set; }
    public IEnumerable<DatasourceColumnBo> AvailableColumns { get; set; } = new List<DatasourceColumnBo>();
    public IEnumerable<DatasourceColumnBo> SelectedColumns { get; set; } = new List<DatasourceColumnBo>();
    public IEnumerable<PlasticisingTileAggregationEnum> SelectedAggregations { get; set; } = new List<PlasticisingTileAggregationEnum>();
}
