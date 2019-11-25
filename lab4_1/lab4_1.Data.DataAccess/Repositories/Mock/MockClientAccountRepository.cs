using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.DomainModel;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Repositories;
using System;
using System.Collections.Generic;

namespace lab4_1.Data.DataAccess.Mock.Repositories
{
    public class MockClientAccountRepository : RepositoryBase, IClientAccountRepository
    {
        public MockClientAccountRepository(DbContext context) : base(context)
        {
        }

        public bool BuyTokens(ClientAccount account, int count)
        {
            return count <= 100;
        }

        public bool CreateClientAccount(ClientAccount account)
        {
            return account.Client != null;
        }

        public ICollection<ClientAccount> GetClientAccounts()
        {
            return new List<ClientAccount>
            {
                new ClientAccount{},
                new ClientAccount{}
            };
        }

        public bool SellTokens(ClientAccount account, int count)
        {
            return count <= 100;
        }
    }
}
