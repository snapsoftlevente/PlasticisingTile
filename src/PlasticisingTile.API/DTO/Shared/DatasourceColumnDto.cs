using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Shared;

public class DatasourceColumnDto : IDto
{
    public string? Key { get; set; }
    public string? Name { get; set; }
}
