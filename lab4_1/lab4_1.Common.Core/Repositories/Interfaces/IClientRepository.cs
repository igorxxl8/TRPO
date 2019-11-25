using lab4_1.Common.DomainModel;
using System.Collections.Generic;

namespace lab4_1.Common.Core.Repositories.Interfaces
{
    public interface IClientRepository
    {
        ICollection<Client> GetClients();
        bool RegisterClient(Client client);
        bool TryLogin(string email, string password);
    }
}
