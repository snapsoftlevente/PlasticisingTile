using Autofac;
using PlasticisingTile.Core.Interfaces;
using PlasticisingTile.Core.Services;

namespace PlasticisingTile.Core;
public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<PlasticisingTileConfigurationService>()
            .As<IPlasticisingTileConfigurationService>()
            .InstancePerLifetimeScope();
    }
}
