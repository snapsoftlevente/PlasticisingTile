using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Enums;

namespace PlasticisingTile.Core.BusinessObjects.Plasticising;
public class PlasticisingTileConfigureRequestBo
{
    public DateTimeRangeFilterBo? DateTimeRangeFilter { get; set; }
    public IEnumerable<string> SelectedColumnKeys { get; set; } = new List<string>();
    public IEnumerable<PlasticisingTileAggregationEnum> SelectedAggregations { get; set; } = new List<PlasticisingTileAggregationEnum>();
}
