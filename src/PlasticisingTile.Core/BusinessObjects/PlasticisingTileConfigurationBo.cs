using PlasticisingTile.Core.Enums;

namespace PlasticisingTile.Core.BusinessObjects;

public class PlasticisingTileConfigurationBo : IBusinessObject
{
    public DateTimeRangeFilterBo? DateTimeRangeFilter { get; set; }
    public IEnumerable<DatasourceColumnBo> AvailableColumns { get; set; } = new List<DatasourceColumnBo>();
    public IEnumerable<DatasourceColumnBo> SelectedColumns { get; set; } = new List<DatasourceColumnBo>();
    public IEnumerable<PlasticisingTileAggregationEnum> SelectedAggregations { get; set; } = new List<PlasticisingTileAggregationEnum>();
}
