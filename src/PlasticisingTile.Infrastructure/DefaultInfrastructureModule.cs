using Autofac;
using PlasticisingTile.Core.Interfaces.Repository;
using PlasticisingTile.Infrastructure.Data.Repositories;

namespace PlasticisingTile.Infrastructure;
public class DefaultInfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(ConfigurationDataRepository<>))
            .As(typeof(IRepository<>))
            .InstancePerLifetimeScope();

        builder.RegisterType<DynamicRepository>()
            .As<IDynamicRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<DynamicRepositoryFactory>()
            .As<IDynamicRepositoryFactory>()
            .InstancePerLifetimeScope();
    }
}
