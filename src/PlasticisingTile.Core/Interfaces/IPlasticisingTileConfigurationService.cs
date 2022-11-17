using PlasticisingTile.Core.BusinessObjects;
using PlasticisingTile.Core.Entities.ConfigurationData;

namespace PlasticisingTile.Core.Interfaces;
public interface IPlasticisingTileConfigurationService : IEntityServiceBase<NewTile, PlasticisingTileConfigurationBo>
{
    Task<PlasticisingTileConfigurationBo> GetPlasticisingTileConfiguration(Guid? id = null);
}
