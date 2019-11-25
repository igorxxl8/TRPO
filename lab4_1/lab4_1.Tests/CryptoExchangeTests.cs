using System.Linq;
using lab4_1.Common.Core.Services.Interfaces;
using lab4_1.Common.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab4_1.Business.Services;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Mock.Repositories;

namespace lab4_1.Tests
{
    [TestClass]
    public class CryptoExchangeTests
    {
        private IClientService _clientService;
        private IAssetHolderService _assetHolderService;
        private IAccountAssetService _accountAssetService;
        private IClientAccountService _clientAccountService;

        [TestInitialize]
        public void Initialize()
        {
            var context = new DbContext();

            var accountAssetRepository = new MockAccountAssetRepository(context);
            var assetHolderRepository = new MockAssetHolderRepository(context);
            var clientAccountRepository = new MockClientAccountRepository(context);
            var clientRepository = new MockClientRepository(context);

            _accountAssetService = new AccountAssetService(accountAssetRepository);
            _assetHolderService = new AssetHolderService(assetHolderRepository);
            _clientAccountService = new ClientAccountService(clientAccountRepository);
            _clientService = new ClientService(clientRepository);
        }

        [TestMethod]
        public void RegisterClient()
        {
            var client = new Client
            {
                FirstName = "Igor",
                LastName = "Turtsevich",
                Email = "email@gmail.com",
                PhoneNumber = "1111111111",
                Password = "12345"
            };

            var isCreated = _clientService.RegisterClient(client);

            Assert.IsTrue(isCreated);
        }

        [TestMethod]
        public void RegisterInvalidClient()
        {
            Client client = null;

            var isCreated = _clientService.RegisterClient(client);

            Assert.IsFalse(isCreated);
        }

        [TestMethod]
        public void TryLogin()
        {
            var email = "email@gmail.com";
            var password = "12345";

            var isLogin = _clientService.TryLogin(email, password);

            Assert.IsTrue(isLogin);
        }

        [TestMethod]
        public void TryInvalidLogin()
        {
            var email = "email@gmail.com";
            var password = "password";

            var isLogin = _clientService.TryLogin(email, password);

            Assert.IsFalse(isLogin);
        }

        [TestMethod]
        public void CreateClientAccount()
        {
            var client = _clientService.GetClients().FirstOrDefault();

            var account = new ClientAccount
            {
                AccountMoney = 100,
                AccountName = "USD.tokens",
                Client = client
            };

            var isCreated = _clientAccountService.CreateClientAccount(account);

            Assert.IsTrue(isCreated);
        }

        [TestMethod]
        public void CreateInvalidClientAccount()
        {
            Client client = null;

            var account = new ClientAccount
            {
                AccountMoney = 100,
                AccountName = "USD.tokens",
                Client = client
            };

            var isCreated = _clientAccountService.CreateClientAccount(account);

            Assert.IsFalse(isCreated);
        }

        [TestMethod]
        public void BuyTokens()
        {
            var account = _clientAccountService.GetClientAccounts().FirstOrDefault();

            var isSuccess = _clientAccountService.BuyTokens(account, 100);

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void BuyTokensMoreThanAvailable()
        {
            var account = _clientAccountService.GetClientAccounts().FirstOrDefault();

            var isSuccess = _clientAccountService.BuyTokens(account, 100000);

            Assert.IsFalse(isSuccess);
        }

        [TestMethod]
        public void SellTokens()
        {
            var account = _clientAccountService.GetClientAccounts().FirstOrDefault();

            var isSuccess = _clientAccountService.SellTokens(account, 100);

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void SellTokensMoreThanAvailable()
        {
            var account = _clientAccountService.GetClientAccounts().FirstOrDefault();

            var isSuccess = _clientAccountService.SellTokens(account, 10000);

            Assert.IsFalse(isSuccess);
        }
    }
}
