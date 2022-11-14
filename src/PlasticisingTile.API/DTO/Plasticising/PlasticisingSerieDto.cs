using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingSerieDto : ISerieDto<int>
{
    public string Name { get; set; } = string.Empty;
    public IEnumerable<int> DataPoints { get; set; } = new List<int>();
}
