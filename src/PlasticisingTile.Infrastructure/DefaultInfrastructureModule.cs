using Autofac;
using PlasticisingTile.Core.Interfaces;
using PlasticisingTile.Infrastructure.Data.Repositories;

namespace PlasticisingTile.Infrastructure;
public class DefaultInfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(ConfigurationDataRepository<>))
            .As(typeof(IRepository<>))
            .InstancePerLifetimeScope();
    }
}
