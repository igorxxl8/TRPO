using Autofac;
using lab4_1.Common.Core.Providers.Interfaces;
using lab4_1.Common.DependencyResolving.Providers;
using System;
using System.Security.Principal;

namespace lab4_1.Common
{
    public static class AutofacResolver
    {
        private static readonly Bootstrapper _bootstrapper = new Bootstrapper();
        private static readonly ContainerBuilder _builder = new ContainerBuilder();
        private static ILifetimeScope _scope;
        private static bool _wasBuilt;

        public static void Setup(AutofacServiceProvider serviceProvider)
        {
            if (_wasBuilt) return;
            _bootstrapper.Initialize(CreateContainer, serviceProvider);
            _scope = _bootstrapper.Container.BeginLifetimeScope();
        }

        public static void TearDown()
        {
            _bootstrapper.ShutDown();
            _scope.Dispose();
        }

        public static T Resolve<T>()
        {
            return _scope.Resolve<T>();
        }

        public static TPresenter ResolvePresenter<TPresenter, TView>(TView view)
        {
            return _scope.Resolve<TPresenter>(new TypedParameter(typeof(TView), view));
        }

        public static TPresenter ResolvePrincipalPresenter<TPresenter, TView>(TView view)
        {
            var principalProvider = _scope.Resolve<IPrincipalProvider>();
            return _scope.Resolve<TPresenter>(new TypedParameter(typeof(TView), view), new TypedParameter(typeof(IPrincipal), principalProvider.Principal));
        }
        public static void RegisterExternalService(Type serviceType, Type interfaceType)
        {
            _builder.RegisterType(serviceType).As(interfaceType);
        }

        private static IContainer CreateContainer(AutofacServiceProvider serviceProvider)
        {
            serviceProvider.RegisterServices(_builder);
            _wasBuilt = true;
            return _builder.Build();
        }
    }
}
