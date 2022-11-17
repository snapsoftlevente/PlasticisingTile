using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Shared;
public class DatasourceBo : IBusinessObject
{
    public int Id { get; set; }
    public string? Realm { get; set; }
    public string? Name { get; set; }
    public string? TableOrStoreName { get; set; }
    public string? TimestampColumnName { get; set; }
    public IEnumerable<DatasourceColumnBo> DatasourceColumns { get; set; } = new List<DatasourceColumnBo>();
}
