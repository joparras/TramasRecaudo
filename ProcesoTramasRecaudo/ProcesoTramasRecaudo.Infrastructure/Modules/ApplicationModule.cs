using Autofac;

namespace ProcesoTramasRecaudo.Infrastructure.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Aplication.ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .AsSelf().InstancePerLifetimeScope();
        }
    }
}
