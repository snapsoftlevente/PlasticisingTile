using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.Entities.ConfigurationData;

namespace PlasticisingTile.Core.Interfaces.Services;
public interface IPlasticisingTileConfigurationService : IEntityServiceBase<NewTile, PlasticisingTileConfigurationBo>
{
    Task<PlasticisingTileBo> GetPlasticisingTileAsync(PlasticisingTileConfigureRequestBo plasticisingTileConfiguration);
    Task<PlasticisingTileConfigurationBo> GetPlasticisingTileConfigurationAsync(Guid? id = null);
}
