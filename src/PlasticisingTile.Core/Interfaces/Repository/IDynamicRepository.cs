using PlasticisingTile.Core.Models.DynamicQuery;

namespace PlasticisingTile.Core.Interfaces.Repository;
public interface IDynamicRepository : IDisposable
{
    Task<IEnumerable<IDictionary<string, TValueTpye>>> QueryAsync<TValueTpye>(DynamicQuery dynamicQuery) where TValueTpye : struct;
}
