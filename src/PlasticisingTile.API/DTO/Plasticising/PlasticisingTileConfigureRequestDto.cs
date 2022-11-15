using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingTileConfigureRequestDto : ITileRequestDto
{
    public DateTime DateFilterFrom { get; set; }
    public DateTime DateFilterTo { get; set; }
    public IEnumerable<int> DataSourceColumnIds { get; set; } = new List<int>();
    public IEnumerable<int> SerieTypes { get; set; } = new List<int>();
}
