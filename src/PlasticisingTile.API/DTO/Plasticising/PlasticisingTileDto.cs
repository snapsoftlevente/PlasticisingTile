using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingTileDto : IDto
{
    public Guid? Id { get; set; }
    public IEnumerable<PlasticisingSerieDto> Series { get; set; } = new List<PlasticisingSerieDto>();
}
