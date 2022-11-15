using PlasticisingTile.Core.Interfaces.Entities;
using PlasticisingTile.Infrastructure.Data.DataContexts;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class ConfigurationDataRepository<T> : RepositoryBase<ConfigurationDataContext, T> where T : class, IConfigurationDataEntity
{
    public ConfigurationDataRepository(ConfigurationDataContext context)
            : base(context)
    {
    }
}
