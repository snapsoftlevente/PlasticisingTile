using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Plasticising;

public class PlasticisingSerieDto : ISerieDto<double>
{
    public string Name { get; set; } = string.Empty;
    public IEnumerable<double> DataPoints { get; set; } = new List<double>();
}
