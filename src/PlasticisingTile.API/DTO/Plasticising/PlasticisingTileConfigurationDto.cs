using PlasticisingTile.API.DTO.Interfaces;
using PlasticisingTile.API.DTO.Shared;
using PlasticisingTile.Core.Enums;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingTileConfigurationDto : IDto
{
    public DateTimeRangeFilterDto? DateTimeRangeFilter { get; set; }
    public IEnumerable<DatasourceColumnDto> AvailableColumns { get; set; } = new List<DatasourceColumnDto>();
    public IEnumerable<DatasourceColumnDto> SelectedColumns { get; set; } = new List<DatasourceColumnDto>();
    public IEnumerable<PlasticisingTileAggregationEnum> SelectedAggregations { get; set; } = new List<PlasticisingTileAggregationEnum>();
}
