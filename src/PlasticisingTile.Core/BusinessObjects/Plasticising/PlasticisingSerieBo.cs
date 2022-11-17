using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Plasticising;
public class PlasticisingSerieBo : IBusinessObject
{
    public string Name { get; set; } = string.Empty;
    public IEnumerable<double> DataPoints { get; set; } = new List<double>();
}
