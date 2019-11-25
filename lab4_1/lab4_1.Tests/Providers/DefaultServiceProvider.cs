using Autofac;
using lab4_1.Business.Services;
using lab4_1.Common.Core.Services.Interfaces;
using lab4_1.Common.DependencyResolving.Providers;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Mock.Repositories;

namespace lab4_1.Tests.Providers
{
    public class DefaultServiceProvider : AutofacServiceProvider
    {
        public override void RegisterServices(ContainerBuilder builder)
        {
            var context = new DbContext();

            var accountAssetRepository = new MockAccountAssetRepository(context);
            var assetHolderRepository = new MockAssetHolderRepository(context);
            var clientAccountRepository = new MockClientAccountRepository(context);
            var clientRepository = new MockClientRepository(context);

            var accountAssetService = new AccountAssetService(accountAssetRepository);
            var assetHolderService = new AssetHolderService(assetHolderRepository);
            var clientAccountService = new ClientAccountService(clientAccountRepository);
            var clientService = new ClientService(clientRepository);

            builder.RegisterInstance(accountAssetService).As<IAccountAssetService>().InstancePerDependency();
            builder.RegisterInstance(assetHolderService).As<IAssetHolderService>().InstancePerDependency();
            builder.RegisterInstance(clientAccountService).As<IClientAccountService>().InstancePerDependency();
            builder.RegisterInstance(clientService).As<IClientService>().InstancePerDependency();
        }
    }
}
