using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Shared;
public class DatasourceColumnBo : IBusinessObject
{
    public string? Key { get; set; }
    public string? Name { get; set; }
}
