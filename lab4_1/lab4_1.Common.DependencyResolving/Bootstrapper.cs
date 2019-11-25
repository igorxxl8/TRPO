using Autofac;
using lab4_1.Common.DependencyResolving.Providers;

namespace lab4_1.Common
{
    public class Bootstrapper
    {
        private static IContainer _containerInstance;

        public IContainer Container => _containerInstance;

        public void Initialize(System.Func<AutofacServiceProvider, IContainer> createContainerCallback, AutofacServiceProvider provider)
        {
            _containerInstance = createContainerCallback(provider);
        }

        public void ShutDown()
        {
            if (_containerInstance != null)
            {
                _containerInstance.Dispose();
                _containerInstance = null;
            }
        }
    }
}
