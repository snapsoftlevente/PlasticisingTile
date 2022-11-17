using Autofac;
using PlasticisingTile.Core.Interfaces.Services;
using PlasticisingTile.Core.Services;

namespace PlasticisingTile.Core;
public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<DatasourceService>()
            .As<IDatasourceService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<PlasticisingTileConfigurationService>()
            .As<IPlasticisingTileConfigurationService>()
            .InstancePerLifetimeScope();
    }
}
