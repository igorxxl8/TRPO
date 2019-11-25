using System.Collections.Generic;
using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.Core.Services.Interfaces;
using lab4_1.Common.DomainModel;

namespace lab4_1.Business.Services
{
    public class ClientAccountService : ServiceBase<IClientAccountRepository>, IClientAccountService
    {
        public ClientAccountService(IClientAccountRepository repository) : base(repository)
        {
        }

        public bool BuyTokens(ClientAccount account, int count)
        {
            return _repository.BuyTokens(account, count);
        }

        public bool CreateClientAccount(ClientAccount account)
        {
            return _repository.CreateClientAccount(account);
        }

        public ICollection<ClientAccount> GetClientAccounts()
        {
            return _repository.GetClientAccounts();
        }

        public bool SellTokens(ClientAccount account, int count)
        {
            return _repository.SellTokens(account, count);
        }
    }
}
