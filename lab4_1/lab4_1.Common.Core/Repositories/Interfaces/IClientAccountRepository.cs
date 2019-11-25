using lab4_1.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Common.Core.Repositories.Interfaces
{
    public interface IClientAccountRepository
    {
        ICollection<ClientAccount> GetClientAccounts();
        bool CreateClientAccount(ClientAccount account);
        bool BuyTokens(ClientAccount account, int count);
        bool SellTokens(ClientAccount account, int count);
    }
}
