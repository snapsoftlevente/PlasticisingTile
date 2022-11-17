using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Plasticising;
public class PlasticisingTileBo : IBusinessObject
{
    public Guid? Id { get; set; }
    public IEnumerable<PlasticisingSerieBo> Series { get; set; } = new List<PlasticisingSerieBo>();
}
