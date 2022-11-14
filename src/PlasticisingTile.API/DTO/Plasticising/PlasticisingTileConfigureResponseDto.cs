using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingTileConfigureResponseDto : ITileResponseDto<PlasticisingSerieDto, int>
{
    public IEnumerable<PlasticisingSerieDto> Series { get; set; } = new List<PlasticisingSerieDto>();
}
