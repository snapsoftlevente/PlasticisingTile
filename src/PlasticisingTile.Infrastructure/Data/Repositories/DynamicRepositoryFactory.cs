using PlasticisingTile.Core.Interfaces.Repository;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class DynamicRepositoryFactory : IDynamicRepositoryFactory
{
    public IDynamicRepository Create(string realm) => new DynamicRepository(realm);
}
