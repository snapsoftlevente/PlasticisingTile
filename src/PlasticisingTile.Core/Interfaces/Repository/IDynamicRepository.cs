using PlasticisingTile.Core.Models.DynamicQuery;

namespace PlasticisingTile.Core.Interfaces.Repository;
public interface IDynamicRepository : IDisposable
{
    Task<IEnumerable<dynamic>> QueryAsync(DynamicQuery dynamicQuery);
}
