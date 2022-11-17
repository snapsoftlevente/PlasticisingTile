using PlasticisingTile.API.DTO.Interfaces;
using PlasticisingTile.API.DTO.Shared;
using PlasticisingTile.Core.Enums;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingTileConfigureRequestDto : ITileRequestDto
{
    public DateTimeRangeFilterDto? DateTimeRangeFilter { get; set; }
    public IEnumerable<string> SelectedColumnKeys { get; set; } = new List<string>();
    public IEnumerable<PlasticisingTileAggregationEnum> SelectedAggregations { get; set; } = new List<PlasticisingTileAggregationEnum>();
}
