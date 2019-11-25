using System.Collections.Generic;
using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.DomainModel;
using lab4_1.Data.DataAccess.Contexts;

namespace lab4_1.Data.DataAccess.Repositories
{
    public class ClientRepository : RepositoryBase, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }

        public ICollection<Client> GetClients()
        {
            throw new System.NotImplementedException();
        }

        public bool RegisterClient(Client client)
        {
            throw new System.NotImplementedException();
        }

        public bool TryLogin(string email, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
