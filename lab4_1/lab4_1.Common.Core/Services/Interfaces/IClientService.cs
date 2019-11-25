using lab4_1.Common.DomainModel;
using System.Collections.Generic;

namespace lab4_1.Common.Core.Services.Interfaces
{
    public interface IClientService
    {
        bool RegisterClient(Client client);
        bool TryLogin(string email, string password);

        ICollection<Client> GetClients();
    }
}
