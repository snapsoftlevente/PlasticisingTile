namespace PlasticisingTile.Core.Interfaces.Repository;
public interface IDynamicRepositoryFactory
{
    IDynamicRepository Create(string realm);
}
