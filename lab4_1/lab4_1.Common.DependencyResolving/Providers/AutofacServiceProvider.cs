using Autofac;
using lab4_1.Common.Core.Providers.Interfaces;

namespace lab4_1.Common.DependencyResolving.Providers
{
    public abstract class AutofacServiceProvider : IServiceProvider<ContainerBuilder>
    {
        public abstract void RegisterServices(ContainerBuilder builder);
    }
}
