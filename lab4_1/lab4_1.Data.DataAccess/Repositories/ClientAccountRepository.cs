using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.DomainModel;
using lab4_1.Data.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Data.DataAccess.Repositories
{
    public class ClientAccountRepository : RepositoryBase, IClientAccountRepository
    {
        public ClientAccountRepository(DbContext context) : base(context)
        {
        }

        public bool BuyTokens(ClientAccount account, int count)
        {
            throw new NotImplementedException();
        }

        public bool CreateClientAccount(ClientAccount account)
        {
            throw new NotImplementedException();
        }

        public ICollection<ClientAccount> GetClientAccounts()
        {
            throw new NotImplementedException();
        }

        public bool SellTokens(ClientAccount account, int count)
        {
            throw new NotImplementedException();
        }
    }
}
