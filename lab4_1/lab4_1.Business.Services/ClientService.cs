using System.Collections.Generic;
using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.Core.Services.Interfaces;
using lab4_1.Common.DomainModel;

namespace lab4_1.Business.Services
{
    public class ClientService : ServiceBase<IClientRepository>, IClientService
    {
        public ClientService(IClientRepository repository) : base(repository)
        {
        }

        public ICollection<Client> GetClients()
        {
            return _repository.GetClients();
        }

        public bool RegisterClient(Client client)
        {
            return _repository.RegisterClient(client);
        }

        public bool TryLogin(string email, string password)
        {
            return _repository.TryLogin(email, password);
        }
    }
}
